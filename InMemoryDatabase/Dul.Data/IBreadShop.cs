using System.Collections.Generic;

namespace Dul.Data
{
    /// <summary>
    /// 제네릭 인터페이스: 공통 CRUD 코드 => BREAD SHOP 패턴 사용
    /// </summary>
    /// <typeparam name="T">모델 클래스</typeparam>
    public interface IBreadShop<T> where T : class
    {
        /// <summary>
        /// 상세
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Browse(int id);

        /// <summary>
        /// 출력
        /// </summary>
        /// <returns></returns>
        List<T> Read();

        /// <summary>
        /// 수정
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Edit(T model);

        /// <summary>
        /// 입력
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        T Add(T model);

        /// <summary>
        /// 삭제
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

        /// <summary>
        /// 검색
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        List<T> Search(string query);

        /// <summary>
        /// 건수
        /// </summary>
        /// <returns></returns>
        int Has();

        /// <summary>
        /// 정렬
        /// </summary>
        /// <param name="orderOption"></param>
        /// <returns></returns>
        IEnumerable<T> Ordering(OrderOption orderOption);

        /// <summary>
        /// 페이징
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<T> Paging(int pageNumber, int pageSize);
    }
}