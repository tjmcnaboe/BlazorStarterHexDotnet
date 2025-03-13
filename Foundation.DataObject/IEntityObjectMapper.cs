namespace Foundation.DataObject
{
    public interface IEntityObjectMapper<T, TVM> where T : class
    {
        TVM MapOut(T data);
        List<TVM> MapOutList(List<T> data);
        T MapIn(TVM data);
        List<T> MapInList(List<TVM> data);
        void MapDtoToTarget(TVM vm, T t);
    }
}
