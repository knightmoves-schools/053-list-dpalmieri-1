namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Return_A_List_Of_Strings_Containing_The_Three_String_Parameters_That_Were_Passed_Into_The_CreateTeam_Method(){
       var classroom = new Classroom();
       List<string> team = classroom.CreateTeam("first", "second", "third");

       Assert.NotNull(team);
       Assert.Equal(3, team.Count());
       Assert.Contains("first", team);
       Assert.Contains("second", team);
       Assert.Contains("third", team);
    }
}