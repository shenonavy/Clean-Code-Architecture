// <copyright file="EmployeeServiceTests.cs" company="Shafran">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Application.Test.Services
{
    using System.Threading;
    using Application.Business.Common.Mappings;
    using Application.Business.RequestHandlers.EmployeeManagement.Commands;
    using Application.Business.RequestHandlers.EmployeeManagement.ViewModels;
    using Application.Core.Services.Interfaces;
    using AutoFixture;
    using AutoMapper;
    using Moq;
    using Shouldly;
    using Xunit;

    /// <summary>
    ///   Employee command test cases.
    /// </summary>
    public class EmployeeServiceTests
    {
        private static IMapper _mapper;

        public Fixture Fixture;

        /// <summary>Initializes a new instance of the <see cref="EmployeeServiceTests" /> class.</summary>
        public EmployeeServiceTests()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        /// <summary>It's can create an employee.</summary>
        [Fact]
        public async void It_can_create_an_employee()
        {
            Fixture = new Fixture();

            var employeeServiceMock = new Mock<IEmployeeService>();

            var employee = new CreateEmployeeCommand
            {
                Data = Fixture.Build<EmployeeVM>()
                        .With(m => m.FirstName, "Shafran").Create(),
            };

            var handler = new CreateEmployeeCommandHandler(employeeServiceMock.Object, _mapper);

            var result = await handler.Handle(employee, CancellationToken.None);

            result.Id.ShouldNotBeNull();
        }
    }
}
