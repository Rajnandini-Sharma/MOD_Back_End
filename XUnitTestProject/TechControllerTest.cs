using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using MOD_TechnologyService.Repository;
using MOD_TechnologyService.Models;
using MOD_TechnologyService.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace XUnitTestProject
{
    public class TechControllerTest
    {
        private readonly Mock<ITechnologyRepo> _repo;
        private readonly TechnologyController _controller;

        public TechControllerTest()
        {
            _repo = new Mock<ITechnologyRepo>();
            _controller = new TechnologyController(_repo.Object);
        }
        private List<Technology> GetTechnologies()
        {
            return new List<Technology>()
            {
                new Technology(){Tech_id=1,Tech_name="Java"},
                new Technology(){Tech_id=1,Tech_name="Java1"},
                new Technology(){Tech_id=1,Tech_name="Java2"}
            };
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetTechnologies());
            var result = _controller.GetAll() as List<Technology>;
            Assert.Equal(3, result.Count);
        }
        [Fact]
        public void GetById()
        {
            _repo.Setup(m => m.GetById(1)).Returns(GetTechnologies()[0]);

        }
        [Fact]
        public void Post()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Put()
        {
            var item = GetTechnologies()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetTechnologies());
            var result = _controller.Delete(1) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Delete_BadRequest()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetTechnologies());
            var result = _controller.Delete(1) as OkResult;
            Assert.NotNull(result);
        }

    }
}
