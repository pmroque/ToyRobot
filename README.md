# Toy Robot by Paul Roque

This is just a one robot entry but the code is ready to extend and can add more robot inside the table/arena

## You can easily add new Action. 

Example: add new JUMP Action with 2 parameter X and Y. The robot position will Jump based on the X and Y parameter

  1. Create A JumpAction class inside the RobotAction Folder. 
     Naming convention = {Action name} + "Action"
                       = "JUMP" + "Action"
                       = JumpAction
     NameSpace         = ToyRobot.RobotAction
  2. Inherit the abstract class Action and implements the astract method DoActionAsync
  3. Create a local variable for your X and Y parameters
  4. Create a constructor for assigning the value for your X and Y parameters
  3. Put you new action logic in DoActionAsync method.
  4. Thats it.. you can now use the Jump action
        JUMP 1,2
        
    '''
    public class JumpAction : Action
    {      
        readonly int X;
        readonly int Y;
       
        public PlaceAction(string x, string y)
        {
            X = int.Parse(x);
            Y = int.Parse(y);
            IsMovableAction = true;
        }
        public override async Task DoActionAsync(Position position)
        {
            position.X = this.X;
            position.Y = this.Y;           
        }
    }
    '''
## You can easily add new Validation

## Unit Test is avaible but not complete.
    
## Game Instruction

  1. Available Command
    ```
    PLACE X,Y,F
    MOVE
    LEFT
    RIGHT
    REPORT
    ```

 2. Sample 

    ```
    PLACE 0,0,NORTH
    MOVE
    REPORT
    Output: 0,1,NORTH
    ```

