using GraphQL.Models;
using GraphQL.Repositories;

namespace GraphQL
{
    public class Query
    {
        public string Hello() => "Hello, world!";

        private readonly IRepository _repository;

        public Query(IRepository repository)
        {
            _repository = repository;
        }


        /*
        query {
          authors {
            id
            name
            bio
            }
        }
        */
        public IEnumerable<Author> GetAuthors() => _repository.GetAllAuthors();



        /*
        query {
          bookById(id: 1) {
            id
            title
          }
        }
         */
        public Book GetBookById(int id) => _repository.GetBookById(id);
    }
}
