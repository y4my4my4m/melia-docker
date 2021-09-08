﻿using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World;

namespace Melia.Channel.Skills.General
{
	/// <summary>
	/// Targeted skill handler implmentation when the client provides a target
	/// </summary>
	public class TargetedSkillHandler : ITargetedSkillHandler
	{
		public void Handle(Skill skill, Character caster, ICombatEntity target)
		{
			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			if (skill.CanOverheat)
				skill.OverheatCounter++;

			Send.ZC_OVERHEAT_CHANGED(caster, skill);

			if (!skill.CanOverheat || skill.IsOverheated)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.OverheatCounter = 0;
			}

			var damage = caster.GetRandomPAtk() + 100;

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, damage);

			if (target == null)
				return;

			if (target.TakeDamage(damage, caster, DamageVisibilityModifier.Invisible))
				Send.ZC_SKILL_CAST_CANCEL(caster, target);
		}
	}
}
