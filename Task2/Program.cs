using Task2;
{
    ILogger logger = new Logger();
    var Work = new Work(logger);
    Work.Worker();

}
