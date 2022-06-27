namespace CoduKata.Test
{
    
    public class RoverTest
    {
        [Theory]
        [InlineData("M",1)]
        [InlineData("MM",2)]
        [InlineData("MMMMMMMMMM",0)]
        void Test_MoveFromZero_ShouldBAtRightPos(string commands,int expextedYPos)
        {
            var rover=new Rover();
            rover.Execute(commands);
            Assert.Equal(expextedYPos, rover.yPos);
        }

        [Theory]
        [InlineData("R",'E')]
        [InlineData("L",'W')]
        [InlineData("LL",'S')]
        [InlineData("LLL",'E')]
        [InlineData("LLLL",'N')]
        void Test_Rotate_RoverShouldPointRightDirection(string commands,char expectedDirection)
        {
            var rover = new Rover();
            rover.Execute(commands);
            Assert.Equal(expectedDirection,rover.Direction);
        }
        
        
      
    }
}

