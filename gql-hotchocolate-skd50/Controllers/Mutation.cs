namespace gql_hotchocolate_skd50.Controllers
{
  using System;

  using gql_hotchocolate_skd50.Models;

  using HotChocolate.AspNetCore.Authorization;

  /*[Authorize]*/
  public class Mutation
  {
    public Book CreateBook(CreateBookInput input)
    {
      if (input.ThrowEr)
      {
        throw new Exception("Ex");
      }
      return new Book
        {
          Title = input.Title,
          Author = new Author
            {
              Name = "Jon Skeet"
            }
        };
    }
      
  }
}