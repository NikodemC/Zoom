﻿using Shouldly;
using System;
using Xunit;
using ZooM.Core.Entitites;
using ZooM.Core.Enums;
using ZooM.Core.Exceptions;

namespace ZooM.Tests.Domain
{
    public class EmployeeTests
    {
        [Theory]
        [InlineData(1920)]
        [InlineData(2010)]
        [InlineData(-1)]
        [InlineData(0)]
        public void CreateEmployee_Should_Throw_Exception_If_Given_YOB_Is_Invalid(int yearOfBirth)
        {
            var exception = Record.Exception(() => new Employee(Guid.NewGuid(), "No Avatar", "Testowy Testo", Position.Grabarz, yearOfBirth));

            exception.ShouldNotBeNull();
            exception.ShouldBeAssignableTo<DomainException>();
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void CreateEmployee_Should_Set_Default_Avatar_If_Given_Avatar_Is_Invalid(string avatar)
        {
            var employee = new Employee(Guid.NewGuid(), avatar, "Testowy Testo", Position.Grabarz, 1980);

            employee.Avatar.ShouldBe(employee.DefaultAvatar);
        }
    }
}
