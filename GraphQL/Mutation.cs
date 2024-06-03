using GraphQL.Models;
using GraphQL.Repositories;

namespace GraphQL
{
    public class AddAuthorInput
    {
        public string Name { get; set; }
        public string Bio { get; set; }
    }

    public class Mutation
    {
        private readonly IRepository _repository;

        public Mutation(IRepository repository)
        {
            _repository = repository;
        }

        /*
        mutation {
          addAuthor(input: { name: "New Author", bio: "Author bio" }) {
            id
            name
            bio
          }
        }
        */
        public Author AddAuthor(AddAuthorInput input)
        {
            var author = new Author { Name = input.Name, Bio = input.Bio };
            return _repository.AddAuthor(author);
        }
    }
}
