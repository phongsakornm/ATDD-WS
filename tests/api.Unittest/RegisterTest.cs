using System;
using xunit;

namespace api.Unittest
{
    public class MemberServiceTest
    {
        [Fact]
        public void GetMemberInfo_Success_ReturnMemberInfo()
        {
            var umayplusCardID = "6273885053341539";
            var personalCardId = "3100505143401";
            var birthDate = "01/01/2530";
            var mobilePhone = "092224955";

            var expectMember = new MemberServiceTest()
            {
                umayplusCardID : "6273885053341539",
                personalCardId : "3100505143401",
                birthDate : "01/01/2530",
                mobilePhone : "092224955",
                FirstName : "Phongsakorn",
                Lastname : "Muenkham"
            };

            MemberService memberService = new MemberService();
            Member actualMember = memberService.GetMemberInfo(umayplusCardID, personalCardId, birthDate, mobilePhone);

            Assert.Equal(expectMember.umayplusCardID, actualMember.umayplusCardID);
            Assert.Equal(expectMember.personalCardId, actualMember.personalCardId);
            Assert.Equal(expectMember.birthDate, actualMember.birthDate);
            Assert.Equal(expectMember.mobilePhone, actualMember.mobilePhone);
            Assert.Equal(expectMember.FirstName, actualMember.FirstName);
            Assert.Equal(expectMember.Lastname, actualMember.Lastname);
        }
    }
}