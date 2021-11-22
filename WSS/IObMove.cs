namespace spaces
{
    public interface IObMove
    {
        //Every objects need to know Y parameter because they all go up or down, then no need for X parameter
        float Y { get; set; }
        //Check if there is a collision
        bool IsCollision(GameObjects obj);
        //Implement the function that objects need to go up or down
        void Move(float GoDown);

    }
}
