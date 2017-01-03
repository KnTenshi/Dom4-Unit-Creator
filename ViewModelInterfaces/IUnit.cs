namespace Dom4.UnitCreator.ViewModels.Interfaces
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using KnTenshi.Utilities.ViewModels.Interfaces;

	public interface IUnit : IViewModel
	{
		#region Mutable Properties

		/// <summary>
		/// Gets or sets the name of the unit.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Gets or sets the description of the unit.
		/// </summary>
		string Description { get; set; }

		/// <summary>
		/// Gets or sets the unit's hit points.
		/// </summary>
		byte HitPoints { get; set; }

		/// <summary>
		/// Gets or sets the unit's size.
		/// </summary>
		byte Size { get; set; }

		/// <summary>
		/// Gets or sets the unit's protection.
		/// </summary>
		byte Protection { get; set; }

		/// <summary>
		/// Gets or sets the unit's magic resistance.
		/// </summary>
		byte MagicResistance { get; set; }

		/// <summary>
		/// Gets or sets the unit's morale.
		/// </summary>
		byte Morale { get; set; }

		/// <summary>
		/// Gets or sets the unit's strength.
		/// </summary>
		byte Strength { get; set; }

		/// <summary>
		/// Gets or sets the unit's attack skill.
		/// </summary>
		byte AttackSkill { get; set; }

		/// <summary>
		/// Gets or sets the unit's defense skill.
		/// </summary>
		byte DefenseSkill { get; set; }

		/// <summary>
		/// Gets or sets the unit's precision.
		/// </summary>
		byte Precision { get; set; }

		/// <summary>
		/// Gets or sets the unit's encumbrance.
		/// </summary>
		byte Encumbrance { get; set; }

		/// <summary>
		/// Gets or sets the unit's map movement.
		/// </summary>
		byte MapMovement { get; set; }

		/// <summary>
		/// Gets or sets the unit's action points.
		/// </summary>
		byte ActionPoints { get; set; }

		/// <summary>
		/// Gets or sets the unit's number of eyes.
		/// </summary>
		byte NumberOfEyes { get; set; }

		/// <summary>
		/// Gets or sets the unit's void sanity.
		/// </summary>
		byte VoidSanity { get; set; }

		#endregion
	}
}
