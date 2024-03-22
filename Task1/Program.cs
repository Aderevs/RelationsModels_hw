//#define ADD_DATA_TO_EMPTY_DB 
using Microsoft.EntityFrameworkCore;

namespace Task1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using MyDatabase db = new MyDatabase();

#if ADD_DATA_TO_EMPTY_DB

            #region creating instances
            //USERS
            Guid[] userIds = new Guid[2];
                for (int i = 0; i < userIds.Length; i++)
                {
                    userIds[i] = Guid.NewGuid();
                }
                User[] users =
                {
                        new User
                        {
                            Id = userIds[0],
                            Name= "Ben",
                            Login = "qwerty",
                            Password = "pass1212",
                            Email = "trin@gmai.com"
                        },
                        new User
                        {
                            Id = userIds[1],
                            Name = "Ron",
                            Login = "zxcvbn",
                            Password = "word3232",
                            Email = "kipin@yahoo.com"
                        }
                };

                //CATEGORIES
                Guid[] categoryIds = new Guid[3];
                for (int i = 0; i < categoryIds.Length; i++)
                {
                    categoryIds[i] = Guid.NewGuid();
                }
                Category[] categories =
                {
                    new Category
                    {
                        Id = categoryIds[0],
                        Name = "Computers"
                    },
                    new Category
                    {
                        Id = categoryIds[1],
                        Name = "Garden equipment"
                    },
                    new Category
                    {
                        Id = categoryIds[2],
                        Name = "Household chemicals"
                    }
                };

                //PRODUCTS
                Guid[] productIds = new Guid[7];
                for (int i = 0; i < productIds.Length; i++)
                {
                    productIds[i] = Guid.NewGuid();
                }
                Product[] products =
                {
                    new Product
                    {
                        Id = productIds[0],
                        Name = "Laptop Lenovo Legion",
                        Price = 50000,
                        CategoryId = categoryIds[0],
                        Description = "Powerful laptop that let to enjoy the best AAA-games wherever you are"
                    },
                    new Product
                    {
                        Id = productIds[1],
                        Name = "Laptop ThinkPad carbon",
                        Price = 75000,
                        CategoryId = categoryIds[0],
                        Description = "Real working station that suits people who value quality and reliability"
                    },
                    new Product
                    {
                        Id = productIds[2],
                        Name = "Steam Deck",
                        Price = 20000,
                        CategoryId = categoryIds[0],
                        Description = "Portable game console can run any game on Steam even when traveling on an airplane or in the middle of the forest in a tent"
                    },
                    new Product
                    {
                        Id = productIds[3],
                        Name = "Garden Shears",
                        Price = 2500,
                        CategoryId = categoryIds[1],
                        Description = "Professional-grade garden shears for precise cutting and trimming"
                    },
                    new Product
                    {
                        Id = productIds[4],
                        Name = "Hedge Trimmer",
                        Price = 15000,
                        CategoryId = categoryIds[1],
                        Description = "Electric hedge trimmer for effortless shaping and maintenance of hedges"
                    },
                    new Product
                    {
                        Id = productIds[5],
                        Name = "Bleach Cleaner",
                        Price = 500,
                        CategoryId = categoryIds[2],
                        Description = "Powerful bleach cleaner for disinfecting and whitening surfaces"
                    },
                    new Product
                    {
                        Id = productIds[6],
                        Name = "All-Purpose Cleaner",
                        Price = 1000,
                        CategoryId = categoryIds[2],
                        Description = "Versatile all-purpose cleaner for effectively cleaning various surfaces"
                    }
                };

                //CARTS
                Guid[] cartIds = new Guid[7];
                for (int i = 0; i < cartIds.Length; i++)
                {
                    cartIds[i] = Guid.NewGuid();
                }
                Cart[] carts =
                {
                    new Cart
                    {
                        Id = cartIds[0],
                        UserId = userIds[0],
                        ProductId = productIds[0],
                    },
                    new Cart
                    {
                        Id = cartIds[1],
                        UserId = userIds[0],
                        ProductId = productIds[2],
                    },
                    new Cart
                    {
                        Id = cartIds[2],
                        UserId = userIds[0],
                        ProductId = productIds[3],
                    },
                    new Cart
                    {
                        Id = cartIds[3],
                        UserId = userIds[1],
                        ProductId = productIds[3],
                    },
                    new Cart
                    {
                        Id = cartIds[4],
                        UserId = userIds[1],
                        ProductId = productIds[5],
                    },
                    new Cart
                    {
                        Id = cartIds[5],
                        UserId = userIds[1],
                        ProductId = productIds[5],
                    },
                    new Cart
                    {
                        Id = cartIds[6],
                        UserId = userIds[1],
                        ProductId = productIds[1],
                    },
                };

                //WORDS
                Guid[] wordIds = new Guid[13];
                for (int i = 0; i < wordIds.Length; i++)
                {
                    wordIds[i] = Guid.NewGuid();
                }
                Word[] words =
                {
                    new Word
                    {
                        Id = wordIds[0],
                        Header = "computer",
                        KeyWord = "laptop"
                    },
                    new Word
                    {
                        Id = wordIds[1],
                        Header = "computer",
                        KeyWord = "Lenovo"
                    },
                    new Word
                    {
                        Id = wordIds[2],
                        Header = "computer",
                        KeyWord = "Thinkpad"
                    },
                    new Word
                    {
                        Id = wordIds[3],
                        Header = "computer",
                        KeyWord = "Legion"
                    },
                    new Word
                    {
                        Id = wordIds[4],
                        Header = "computer",
                        KeyWord = "game"
                    },
                    new Word
                    {
                        Id = wordIds[5],
                        Header = "computer",
                        KeyWord = "console"
                    },
                    new Word
                    {
                        Id = wordIds[6],
                        Header = "garden",
                        KeyWord = "scissors"
                    },
                    new Word
                    {
                        Id = wordIds[7],
                        Header = "garden",
                        KeyWord = "shears"
                    },
                    new Word
                    {
                        Id = wordIds[8],
                        Header = "garden",
                        KeyWord = "bushes"
                    },
                    new Word
                    {
                        Id = wordIds[9],
                        Header = "garden",
                        KeyWord = "trimmer"
                    },
                    new Word
                    {
                        Id = wordIds[10],
                        Header = "chemical",
                        KeyWord = "cleaner"
                    },
                    new Word
                    {
                        Id = wordIds[11],
                        Header = "chemical",
                        KeyWord = "bleach"
                    },
                    new Word
                    {
                        Id = wordIds[12],
                        Header = "chemical",
                        KeyWord = "all-purpose"
                    }
                };

                //KEY PARAMS
                Guid[] keyParamsIds = new Guid[16];
                for (int i = 0; i < keyParamsIds.Length; i++)
                {
                    keyParamsIds[i] = Guid.NewGuid();
                }
                KeyParams[] keyParamses =
                {
                    new KeyParams
                    {
                        Id = keyParamsIds[0],
                        ProductId = productIds[0],
                        KeyWordsId = wordIds[0],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[1],
                        ProductId = productIds[0],
                        KeyWordsId = wordIds[1],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[2],
                        ProductId = productIds[0],
                        KeyWordsId = wordIds[3],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[3],
                        ProductId = productIds[1],
                        KeyWordsId = wordIds[1],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[4],
                        ProductId = productIds[1],
                        KeyWordsId = wordIds[2],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[5],
                        ProductId = productIds[2],
                        KeyWordsId = wordIds[4],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[6],
                        ProductId = productIds[2],
                        KeyWordsId = wordIds[5],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[7],
                        ProductId = productIds[3],
                        KeyWordsId = wordIds[6],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[8],
                        ProductId = productIds[3],
                        KeyWordsId = wordIds[7],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[9],
                        ProductId = productIds[3],
                        KeyWordsId = wordIds[8],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[10],
                        ProductId = productIds[4],
                        KeyWordsId = wordIds[8],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[11],
                        ProductId = productIds[4],
                        KeyWordsId = wordIds[9],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[12],
                        ProductId = productIds[5],
                        KeyWordsId = wordIds[10],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[13],
                        ProductId = productIds[5],
                        KeyWordsId = wordIds[11],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[14],
                        ProductId = productIds[6],
                        KeyWordsId = wordIds[10],
                    },
                    new KeyParams
                    {
                        Id = keyParamsIds[15],
                        ProductId = productIds[6],
                        KeyWordsId = wordIds[12],
                    }
                };
            #endregion

            #region pushing data to db
            //Save data to Db
            foreach (User user in users)
                {
                    db.Add(user);
                }
                await db.SaveChangesAsync();

                foreach (Category category in categories)
                {
                    db.Add(category);
                }
                await db.SaveChangesAsync();

                foreach (Product product in products)
                {
                    db.Add(product);
                }
                await db.SaveChangesAsync();

                foreach (Cart cart in carts)
                {
                    db.Add(cart);
                }
                await db.SaveChangesAsync();

                foreach (Word word in words)
                {
                    db.Add(word);
                }
                await db.SaveChangesAsync();

                foreach (KeyParams keyParams in keyParamses)
                {
                    db.Add(keyParams);
                }
                await db.SaveChangesAsync();
                await Console.Out.WriteLineAsync("Data was successfully written to db");
            
            #endregion

#endif
            var usersFromDb = await db.Users
                .Include(u=> u.Cart)
                .ThenInclude(c => c.Product)
                .ThenInclude(p => p.KeyWords)
                .ThenInclude(kw => kw.KeyWords)
                .ToListAsync();
            await Console.Out.WriteLineAsync("Users:");
            foreach (var user in usersFromDb)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                await Console.Out.WriteLineAsync($"-{user.Name}");
                foreach (Cart cart in user.Cart)
                {
                    Console.ResetColor();
                    await Console.Out.WriteAsync($"--{cart.Product.Name} ( ");
                    foreach (KeyParams keyParams in cart.Product.KeyWords)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        await Console.Out.WriteAsync($"{keyParams.KeyWords.KeyWord} | ");
                    }
                    Console.ResetColor();
                    await Console.Out.WriteLineAsync(")");
                }
                await Console.Out.WriteLineAsync();
            }
        }
    }
}
