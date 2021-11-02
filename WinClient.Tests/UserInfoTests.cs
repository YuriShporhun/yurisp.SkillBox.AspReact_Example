using Application.User.Dto;
using NUnit.Framework;
using System;
using WinClient.NTier.Models;

namespace WinClient.NTier.Tests
{
    [TestFixture]
    public class UserInfoTests
    {
        private UserDto _correctUserDto;

        [SetUp]
        public void SetUp()
        {
            _correctUserDto = new UserDto
            {
                DisplayName = "Name"
            };
        }

        [Test]
        public void SetDisplayName_DisplayNameIsCorrect_ShouldRaisePropertyChanged()
        {
            var raised = false;
            UserInfo userInfo = new(_correctUserDto);
            userInfo.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(userInfo.DisplayName))
                {
                    raised = true;
                }
            };
            userInfo.DisplayName = "NewName";
            Assert.IsTrue(raised);
        }

        [Test]
        public void Ctor_DtoIsNull_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var userInfo = new UserInfo(null);
            });
        }

        [Test]
        public void GetDisplayName_DtoIsCorrect_ShouldPass()
        {
            var userInfo = new UserInfo(_correctUserDto);
            Assert.AreEqual(userInfo.DisplayName, _correctUserDto.DisplayName);
        }
    }
}
