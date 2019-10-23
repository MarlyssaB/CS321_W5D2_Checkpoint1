using System;
using CS321_W5D2_BlogAPI.ApiModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CS321_W5D2_BlogAPI.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS321_W5D2_BlogAPI.Controllers
{
    // TODO: secure controller actions that change data
    [Route("api/[controller]")]
    public class PostsController : Controller
    {

        private readonly IPostService _postService;

        // TODO: inject PostService
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        // TODO: get posts for blog
        // TODO: allow anyone to get, even if not logged in
        // GET /api/blogs/{blogId}/posts
        [HttpGet("/api/blogs/{blogId}/posts")]
        public IActionResult Get(int blogId)
        {
            // TODO: replace the code below with the correct implementation
            var content = @"<p>
Eget placerat sit placerat vulputate penatibus aenean leo platea aliquam et. Hendrerit facilisi mollis dolor quam quisque non ultrices adipiscing quis egestas. Maecenas praesent ultrices lorem porta. Consequat mattis blandit ultrices nec dapibus euismod, lobortis rutrum erat nullam. Enim himenaeos habitasse nec ornare. Dictumst malesuada, penatibus nisi nostra congue morbi mauris penatibus turpis. Urna id maecenas blandit a curabitur auctor conubia sodales.
</p>
<p>
Montes sodales pellentesque lacinia vel nostra vehicula sociosqu! Tempor lobortis pulvinar nec fermentum maecenas. Lectus quis felis fusce egestas phasellus nulla mollis cursus sem habitant adipiscing. Consectetur euismod convallis velit imperdiet lobortis accumsan id feugiat ridiculus tempus? Porttitor vitae suscipit quisque fames etiam per lacinia! Ligula eget amet ultricies! Justo pellentesque aptent cubilia phasellus. Nulla quis quis rutrum ut non. Netus diam quisque per habitasse potenti facilisi est porta quis sagittis adipiscing. Proin sollicitudin mus hac laoreet nisl varius velit malesuada fringilla gravida. Nostra placerat pulvinar velit eleifend mattis nisi pretium metus.
</p>
<p>
Consequat nisl feugiat habitant vel a. Neque litora leo pretium a. Velit vel eu nunc convallis tortor habitasse dictum inceptos? Malesuada risus ridiculus aptent vel habitasse, parturient nascetur auctor ultricies sodales malesuada. Vestibulum adipiscing id habitant, libero taciti mi fusce hendrerit eget nibh ad. Mattis, eget orci cras suscipit lobortis vitae maecenas leo himenaeos pretium fusce? Proin dui elit proin magna in convallis varius facilisis! Aliquam torquent, rhoncus lectus. Auctor luctus sit.
</p>
<p>
Elit quisque volutpat turpis enim sodales dolor ligula amet sem primis posuere morbi. Arcu habitasse nascetur varius dignissim lobortis volutpat erat adipiscing et. Vestibulum cubilia eros est magna nibh ut arcu lacinia ac laoreet. Dis mattis, mauris et quam erat nec velit. Litora elit interdum platea viverra non fringilla posuere. Luctus nulla suscipit eget porttitor consectetur netus aptent fusce molestie quam ligula justo. Et urna consectetur arcu conubia, eleifend sapien parturient dapibus habitant habitant. Imperdiet aptent volutpat mauris conubia sodales. Quis euismod mauris eu.
</p>
<p>
Sit per suscipit congue. Malesuada vitae ridiculus hendrerit massa porttitor scelerisque iaculis ut euismod habitasse vitae velit. Enim congue mi convallis nunc duis fusce tempor lacinia magna. Sem habitant nascetur hendrerit senectus. Sem sit purus volutpat suscipit nisi convallis quis mi! Facilisis venenatis metus proin sapien odio montes? Nibh elementum vivamus adipiscing sagittis himenaeos fames. Metus rutrum amet dis elit. Ultrices sagittis integer fusce vitae sodales primis facilisis dapibus ornare mus ullamcorper mi. Eget montes cum.
</p>";
            return Ok(new PostModel[] {
                new PostModel
                {
                    Id = 1,
                    BlogId = 1,
                    BlogName = "Fix Me!",
                    Title = "Fix Me! Post #1",
                    Content = "<i>Implement GET /api/blogs/{blogId}/posts</i><br/>" + content,
                    AuthorName = "unknown",
                    DatePublished = DateTime.Now
                },
                new PostModel
                {
                    Id = 1,
                    BlogId = 1,
                    BlogName = "Fix Me!",
                    Title = "Fix Me! Post #2",
                    Content = "<i>Implement GET /api/blogs/{blogId}/posts</i><br/>" + content,
                    AuthorName = "unknown",
                    DatePublished = DateTime.Now
                }
            });
        }

        // TODO: get post by id
        // TODO: allow anyone to get, even if not logged in
        // GET api/blogs/{blogId}/posts/{postId}
        [HttpGet("/api/blogs/{blogId}/posts/{postId}")]
        public IActionResult Get(int blogId, int postId)
        {
            // TODO: replace the code below with the correct implementation
            var content = @"<p>
Eget placerat sit placerat vulputate penatibus aenean leo platea aliquam et. Hendrerit facilisi mollis dolor quam quisque non ultrices adipiscing quis egestas. Maecenas praesent ultrices lorem porta. Consequat mattis blandit ultrices nec dapibus euismod, lobortis rutrum erat nullam. Enim himenaeos habitasse nec ornare. Dictumst malesuada, penatibus nisi nostra congue morbi mauris penatibus turpis. Urna id maecenas blandit a curabitur auctor conubia sodales.
</p>
<p>
Montes sodales pellentesque lacinia vel nostra vehicula sociosqu! Tempor lobortis pulvinar nec fermentum maecenas. Lectus quis felis fusce egestas phasellus nulla mollis cursus sem habitant adipiscing. Consectetur euismod convallis velit imperdiet lobortis accumsan id feugiat ridiculus tempus? Porttitor vitae suscipit quisque fames etiam per lacinia! Ligula eget amet ultricies! Justo pellentesque aptent cubilia phasellus. Nulla quis quis rutrum ut non. Netus diam quisque per habitasse potenti facilisi est porta quis sagittis adipiscing. Proin sollicitudin mus hac laoreet nisl varius velit malesuada fringilla gravida. Nostra placerat pulvinar velit eleifend mattis nisi pretium metus.
</p>
<p>
Consequat nisl feugiat habitant vel a. Neque litora leo pretium a. Velit vel eu nunc convallis tortor habitasse dictum inceptos? Malesuada risus ridiculus aptent vel habitasse, parturient nascetur auctor ultricies sodales malesuada. Vestibulum adipiscing id habitant, libero taciti mi fusce hendrerit eget nibh ad. Mattis, eget orci cras suscipit lobortis vitae maecenas leo himenaeos pretium fusce? Proin dui elit proin magna in convallis varius facilisis! Aliquam torquent, rhoncus lectus. Auctor luctus sit.
</p>
<p>
Elit quisque volutpat turpis enim sodales dolor ligula amet sem primis posuere morbi. Arcu habitasse nascetur varius dignissim lobortis volutpat erat adipiscing et. Vestibulum cubilia eros est magna nibh ut arcu lacinia ac laoreet. Dis mattis, mauris et quam erat nec velit. Litora elit interdum platea viverra non fringilla posuere. Luctus nulla suscipit eget porttitor consectetur netus aptent fusce molestie quam ligula justo. Et urna consectetur arcu conubia, eleifend sapien parturient dapibus habitant habitant. Imperdiet aptent volutpat mauris conubia sodales. Quis euismod mauris eu.
</p>
<p>
Sit per suscipit congue. Malesuada vitae ridiculus hendrerit massa porttitor scelerisque iaculis ut euismod habitasse vitae velit. Enim congue mi convallis nunc duis fusce tempor lacinia magna. Sem habitant nascetur hendrerit senectus. Sem sit purus volutpat suscipit nisi convallis quis mi! Facilisis venenatis metus proin sapien odio montes? Nibh elementum vivamus adipiscing sagittis himenaeos fames. Metus rutrum amet dis elit. Ultrices sagittis integer fusce vitae sodales primis facilisis dapibus ornare mus ullamcorper mi. Eget montes cum.
</p>";
            return Ok(
                new PostModel
                {
                    Id = 1,
                    BlogId = 1,
                    BlogName = "Fix Me!",
                    Title = "Fix Me!",
                    Content = @"<i>Implement GET /api/blogs/{blogId}/posts</i><br/>" + content,
                    AuthorName = "unknown",
                    DatePublished = DateTime.Now
                }
            );
        }

        // TODO: add a new post to blog
        // POST /api/blogs/{blogId}/post
        [HttpPost("/api/blogs/{blogId}/posts")]
        public IActionResult Post(int blogId, [FromBody]PostModel postModel)
        {
            // TODO: replace the code below with the correct implementation
            ModelState.AddModelError("AddPost", "Fix Me! Implement POST /api/blogs{blogId}/posts");
            return BadRequest(ModelState);
        }

        // PUT /api/blogs/{blogId}/posts/{postId}
        [HttpPut("/api/blogs/{blogId}/posts/{postId}")]
        public IActionResult Put(int blogId, int postId, [FromBody]PostModel postModel)
        {
            try
            {
                var updatedPost = _postService.Update(postModel.ToDomainModel());
                return Ok(updatedPost);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("UpdatePost", ex.Message);
                return BadRequest(ModelState);
            }
        }

        // TODO: delete post by id
        // DELETE /api/blogs/{blogId}/posts/{postId}
        [HttpDelete("/api/blogs/{blogId}/posts/{postId}")]
        public IActionResult Delete(int blogId, int postId)
        {
            // TODO: replace the code below with the correct implementation
            ModelState.AddModelError("DeletePost", "Fix Me! Implement DELETE /api/blogs{blogId}/posts/{postId}");
            return BadRequest(ModelState);
        }
    }
}
