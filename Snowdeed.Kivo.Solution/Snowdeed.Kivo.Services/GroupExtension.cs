namespace Snowdeed.Kivo.Services
{
    using System;
    using Snowdeed.Kivo.Data.Musics;
    using Snowdeed.Kivo.Dto;

    public static class GroupExtension
    {
        public static GroupDto ConvertToGroupDto(this Group entity)
        {
            if (entity == null)
                return null;

            var groupDto = new GroupDto()
            {
                Group_Name = entity.Group_Name
            };

            return groupDto;
        }

        public static Group ConvertToGroup(this GroupDto dto)
        {
            if (dto == null)
                return null;

            var group = new Group()
            {
                ID = Guid.NewGuid(),
                Group_Name = dto.Group_Name
            };

            return group;
        }

    }
}