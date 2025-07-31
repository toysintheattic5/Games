using Games.API.Models.Application;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Games.API.Models.Domain
{
    public class DesirabilityTier
    {
        private DesirabilityTier(DesirabilityTierEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
            Description = @enum.GetEnumDescription();
        }


        protected DesirabilityTier() { } //For EF


        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required, MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }


        public static implicit operator DesirabilityTier(DesirabilityTierEnum @enum) => new DesirabilityTier(@enum);

        public static implicit operator DesirabilityTierEnum(DesirabilityTier attributeType) => (DesirabilityTierEnum)attributeType.Id;
    }


    public enum DesirabilityTierEnum
    {
        [Description("Undecided")]
        Undecided = 0,
        [Description("No, just no")]
        No,
        [Description("Probably Not")]
        ProbablyNot,
        [Description("Could be fun though")]
        Maybe,
        [Description("This sounds like something I'd like to play.")]
        SoundsGood,
        [Description("This is a game I want to play.")]
        Want,
        [Description("For reals, I really want to play this.")]
        ForReals,
        [Description("Seriously, I must have this game ASAP.")]
        Seriously,
        [Description("I must play this before I die.")]
        BeforeIDie
    }
}