 namespace CoduKata;

    public class Rover
    {
        public int yPos { get; private set; }

        public char Direction
        {
            get;
            private set;
        }
        private int _directionInt;
        public Rover()
        {
            yPos = 0;
            Direction = 'N';
        }
        
        public void Execute(string commands)
        {
            for (int i = 0; i < commands.Length;i++)
            {
                var command = commands[i];
                if (command == 'M')
                {
                    MoveRover();
                }
                else
                {
                    ChangeRoverDirection(command);
                }
            }
        }

        
        
        private void ChangeRoverDirection(char command)
        {
            if (Direction == 'N')
            {
                Direction = command == 'L' ? 'W' : 'E';
                return;
            }
            if (Direction == 'W')
            {
                Direction = command == 'L' ? 'S' : 'N';
                return;
            }
            if (Direction == 'S')
            {
                Direction = command == 'L' ? 'E' : 'W';
                return;
            }
            if (Direction == 'E')
            {
                Direction = command == 'L' ? 'N' : 'S';
                return;
            }

        }

        private void MoveRover()
        {
            yPos++;
            if (yPos > 9)
            {
                yPos = 0;
                if (yPos > 9)
                {
                    yPos = 0;
                }
            }
        }
        
    }
