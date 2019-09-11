﻿using System.Collections.Generic;
using System.Linq;
using ZooM.Application.DTO;
using ZooM.Core.Entitites;

namespace ZooM.Infrastructure.Databases.NHibernate.Entities.Extensions
{
    internal static class AnimalExtensions
    {
        public static AnimalEntity AsEntity(this Animal animal)
            => new AnimalEntity
            {
                Id = animal.Id,
                Avatar = animal.Avatar,
                Name = animal.Name,
                Type = animal.Type,
                Weight = animal.Weight,
                YearOfBirth = animal.YearOfBirth,
                AreaNo = animal.AreaNo,
                CageNo = animal.CageNo
            };

        public static Animal AsAnimal(this AnimalEntity entity)
        => new Animal(entity.Id, entity.Avatar, entity.Name, entity.Type, entity.Weight, entity.YearOfBirth, entity.AreaNo, entity.CageNo);

        public static AnimalDto AsDto(this AnimalEntity entity)
            => new AnimalDto
            {
                Id = entity.Id,
                Avatar = entity.Avatar,
                Name = entity.Name,
                Type = entity.Type,
                Weight = entity.Weight,
                YearOfBirth = entity.YearOfBirth,
                AreaNo = entity.AreaNo,
                CageNo = entity.CageNo
            };

        public static IEnumerable<AnimalDto> AsDtos(this IEnumerable<AnimalEntity> animals)
            => animals.Select(a => a.AsDto());
    }
}