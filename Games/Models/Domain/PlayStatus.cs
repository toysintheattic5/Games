using Games.API.Models.Application;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Games.API.Models.Domain
{
    public class PlayStatus
    {
        private PlayStatus(PlayStatusEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
            Description = @enum.GetEnumDescription();
        }


        protected PlayStatus() { } //For EF


        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required, MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }


        public static implicit operator PlayStatus(PlayStatusEnum @enum) => new PlayStatus(@enum);

        public static implicit operator PlayStatusEnum(PlayStatus attributeType) => (PlayStatusEnum)attributeType.Id;
    }


    public enum PlayStatusEnum
    {
        [Description("Not played yet.")]
        NotPlayed = 0,
        [Description("I refuse to ever play this.")]
        WontPlay,
        [Description("I started it, but I don't think I'll finish it.")]
        Abandoned,
        [Description("I plan to play this at some point.")]
        PlanToPlay,
        [Description("I started playing this, but am not currently playing.")]
        Playing,
        [Description("I have put this on hold for now.")]
        OnHold,
        [Description("I have completed this game.")]
        Completed,
        [Description("100 % achievements unlocked!")]
        FullyCompleted
    }
}
