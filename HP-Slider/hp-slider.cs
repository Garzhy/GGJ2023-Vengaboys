class hp-slider
{
    const int max = 10;
    const int min = 0;
    int current;
    const int difference = 1;

    public int SubHP(int current, int difference){
        current = current - difference;
        return current;
    }

    public bool CheckHP(int current){
        if (current <= 0){
            return true;
        }
        else {
            return false;
        }
    }
}