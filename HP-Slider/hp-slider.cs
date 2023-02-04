public class Hp
{
    private const int max;
    private const int min;
    private int current;
    private const int dif = 1; //Adds and subtracts

    /// Initializes max, min, and current
    public Hp(int giveMax, int giveMin){
        max = giveMax;
        min = giveMin;
        current = giveMax;
    }
    /// Initializes max and min hp for main hp bar
    public Hp(){
        max = 10;
        min = 0;
    }
    /// Gets current health 
    public int getCurrent(){
        return current;
    }
    /// Adds/Subtracts HP 
    public int changeHP(bool positiveChange){
        if(positiveChange){
            current += dif;
        }
        else {
            current -= dif;
        }
        return current;
    }
    /// Checks current HP to see if game over 
    public bool CheckHP(int current){
        if (current <= 0){
            return true;
        }
        else {
            return false;
        }
    }
}