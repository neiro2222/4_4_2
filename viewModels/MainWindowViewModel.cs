using System.Collections.Generic;
using System;
using Mvvm.Models;

namespace Mvvm.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        BlogEntities =
        [
            new BlogsEntity {Article = "Скоро лето...", Text = "Лето — это время года, которое с нетерпением ждут многие люди. Оно ассоциируется с отдыхом, путешествиями, солнцем и множеством возможностей для занятий на свежем воздухе. Однако, грядущее лето вызывает не только радость, но и размышления о том, каким оно будет и что оно принесет.", Tags = ["Tag1, Tag2"], ImagePath="dead.png"}
        ];
        NewsEntities =
        [
            new NewsEntity { Text = "news 1", PublishDate = DateTime.Now},
            new NewsEntity { Text = "news 2", PublishDate = DateTime.Now},
            new NewsEntity { Text = "news 3", PublishDate = DateTime.Now}
        ];
    }
    public List<BlogsEntity> BlogEntities { get; set; }

    public List<NewsEntity> NewsEntities { get; set; }

}