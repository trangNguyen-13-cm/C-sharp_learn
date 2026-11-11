class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    } 

    // TODO: define the 'RemainingMinutesInOven()' method
public int RemainingMinutesInOven(int Min){
    return 40 - Min;
}
    // TODO: define the 'PreparationTimeInMinutes()' method
public int PreparationTimeInMinutes(int Amount){
    return 2*Amount;
}
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int Amount, int Min){
    int result = 2 * Amount + Min;
    return result;
}
    
}
