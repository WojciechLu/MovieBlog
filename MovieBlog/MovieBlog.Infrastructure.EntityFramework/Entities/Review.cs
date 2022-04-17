﻿namespace MovieBlog.Infrastructure.EntityFramework.Entities;

public class Review
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public int MovieId { get; set; }
    public string Description { get; set; }
    public int Assessment { get; set; }
    public Movie RatedMovie { get; set; }
    public User Author { get; set; }
    public ICollection<Comment> Comments { get; set; }
}
