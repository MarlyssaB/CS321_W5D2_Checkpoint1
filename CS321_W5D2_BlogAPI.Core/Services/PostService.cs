using System;
using System.Collections.Generic;
using CS321_W5D2_BlogAPI.Core.Models;

namespace CS321_W5D2_BlogAPI.Core.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IBlogRepository _blogRepository;
        private readonly IUserService _userService;

        public PostService(IPostRepository postRepository, IBlogRepository blogRepository, IUserService userService)
        {
            _postRepository = postRepository;
            _blogRepository = blogRepository;
            _userService = userService;
        }

        public Post Add(Post newPost)
        {
            // TODO: Prevent users from adding to a blog that isn't theirs
            //     Use the _userService to get the current users id.
            //     You may have to retrieve the blog in order to check user id
            // TODO: assign the current date to DatePublished
            var currentUser = _userService.CurrentUserId;
            var currentBlog = _blogRepository.Get(newPost.BlogId);
            if (currentUser == currentBlog.UserId)
            {
                newPost.DatePublished = DateTime.Now;
                return _postRepository.Add(newPost);
            }
            else
            {
                throw new ApplicationException("This is not your blog!");
            }


        }

        public Post Get(int id)
        {
            return _postRepository.Get(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll();
        }
        
        public IEnumerable<Post> GetBlogPosts(int blogId)
        {
            return _postRepository.GetBlogPosts(blogId);
        }

        public void Remove(int id)
        {
            var post = this.Get(id);
            
            if (_userService.CurrentUserId == post.Blog.UserId)
            {
                _postRepository.Remove(id);
                return;
            }
            else
            {
                throw new ApplicationException("This is not your blog!");
            }
        }

        public Post Update(Post updatedPost)
        {
            var currentUser = _userService.CurrentUserId;
            var blog = _blogRepository.Get(updatedPost.Id);
            if (currentUser == blog.UserId)
            {
                return _postRepository.Update(updatedPost);
            }
            else
            {
                throw new ApplicationException("This is not your blog!");
            }
        }

    }
}
