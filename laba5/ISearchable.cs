interface ISearchable
{
    List<Tovar> SearchByCriteria(List<Tovar> tovary, Func<Tovar, bool> criteria);
}