﻿using Games.API.Models.Domain;
using Games.API.Models.Application;
using Attribute = Games.API.Models.Domain.Attribute;

namespace Games.API.Models.DTO
{
    public class ProductDto
    {
        public string Name { get; set; }
        public List<Platform> Platforms { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public List<Note> Notes { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Settings { get; set; }
        public List<string> Perspectives { get; set; }
        public string PlayStatus { get; set; }
        public string Tier { get; set; }
        public List<string> Tags { get; set; }


        public ProductDto(Product p)
        {
            Name = p.Name;
            Platforms = p.Platforms;
            Description = p.Description;
            Priority = p.Priority;
            Notes = p.Notes;
            Genres = p.Attributes.Where(a => a.AttributeType == AttributeTypeEnum.Genre).Select(a => a.Name).ToList();
            Settings = p.Attributes.Where(a => a.AttributeType == AttributeTypeEnum.Setting).Select(a => a.Name).ToList();
            Perspectives = p.Attributes.Where(a => a.AttributeType == AttributeTypeEnum.Perspective).Select(a => a.Name).ToList();
            PlayStatus = p.PlayStatus.Name;
            Tier = p.DesirabilityTier.Name;
            Tags = p.Attributes.Where(a => a.AttributeType == AttributeTypeEnum.GeneralTag).Select(a => a.Name).ToList();
        }


    }
}
