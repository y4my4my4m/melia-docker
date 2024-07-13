﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman.Doppelsoeldner
{
	/// <summary>
	/// Handler for the Doppelsoeldner skill Redel.
	/// </summary>
	[SkillHandler(SkillId.Doppelsoeldner_Redel)]
	public class Doppelsoeldner_Redel : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			// This is a combo skill, can only be cast when the previous skills adds this buff
			if (!caster.IsBuffActive(BuffId.Redel_Buff))
			{
				caster.ServerMessage(Localization.Get("Can't use this skill."));
				return;
			}
			var buffComponent = caster.Components.Get<BuffComponent>();
			if (buffComponent.Has(BuffId.Redel_Buff))
				buffComponent.Remove(BuffId.Redel_Buff);

			skill.IncreaseOverheat();
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 70, width: 30, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			this.Attack(skill, caster, splashArea);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(600);
			var damageDelay1 = TimeSpan.FromMilliseconds(50);
			var damageDelay2 = TimeSpan.FromMilliseconds(50);
			var delayBetweenHits = TimeSpan.FromMilliseconds(200);
			var skillHitDelay = TimeSpan.Zero;
			var deedsOfValorBonus = 1.0f;

			if (caster.IsBuffActive(BuffId.DeedsOfValor))
			{
				var buff = caster.Components.Get<BuffComponent>().Get(BuffId.DeedsOfValor);
				deedsOfValorBonus = buff.NumArg2;
			}

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = SkillModifier.Default;
				modifier.HitCount = 2;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				skillHitResult.Damage *= deedsOfValorBonus;
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay1, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				hits.Add(skillHit);
				Send.ZC_SKILL_HIT_INFO(caster, hits);
			}

			await Task.Delay(delayBetweenHits);
			hits.Clear();
			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = new SkillModifier();

				modifier.HitCount = 2;

				var skillHitResult2 = SCR_SkillHit(caster, target, skill, modifier);
				skillHitResult2.Damage *= deedsOfValorBonus;
				target.TakeDamage(skillHitResult2.Damage, caster);

				var skillHit2 = new SkillHitInfo(caster, target, skill, skillHitResult2, damageDelay2, skillHitDelay);
				skillHit2.HitEffect = HitEffect.Impact;
				hits.Add(skillHit2);
				Send.ZC_SKILL_HIT_INFO(caster, hits);
			}

			await Task.Delay(delayBetweenHits);
			hits.Clear();
			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = new SkillModifier();

				modifier.HitCount = 2;

				var skillHitResult3 = SCR_SkillHit(caster, target, skill, modifier);
				skillHitResult3.Damage *= deedsOfValorBonus;
				target.TakeDamage(skillHitResult3.Damage, caster);

				var skillHit3 = new SkillHitInfo(caster, target, skill, skillHitResult3, damageDelay2, skillHitDelay);
				skillHit3.HitEffect = HitEffect.Impact;
				hits.Add(skillHit3);
				Send.ZC_SKILL_HIT_INFO(caster, hits);
			}

			await Task.Delay(delayBetweenHits);
			hits.Clear();
			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = new SkillModifier();

				modifier.HitCount = 2;

				var skillHitResult4 = SCR_SkillHit(caster, target, skill, modifier);
				skillHitResult4.Damage *= deedsOfValorBonus;
				target.TakeDamage(skillHitResult4.Damage, caster);

				var skillHit4 = new SkillHitInfo(caster, target, skill, skillHitResult4, damageDelay2, skillHitDelay);
				skillHit4.HitEffect = HitEffect.Impact;
				hits.Add(skillHit4);
				Send.ZC_SKILL_HIT_INFO(caster, hits);
			}

			await Task.Delay(delayBetweenHits);
			hits.Clear();
			targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				SkillModifier modifier = new SkillModifier();

				modifier.HitCount = 2;

				var skillHitResult5 = SCR_SkillHit(caster, target, skill, modifier);
				skillHitResult5.Damage *= deedsOfValorBonus;
				target.TakeDamage(skillHitResult5.Damage, caster);

				var skillHit5 = new SkillHitInfo(caster, target, skill, skillHitResult5, damageDelay2, skillHitDelay);
				skillHit5.HitEffect = HitEffect.Impact;
				hits.Add(skillHit5);
				Send.ZC_SKILL_HIT_INFO(caster, hits);
			}
		}
	}
}
