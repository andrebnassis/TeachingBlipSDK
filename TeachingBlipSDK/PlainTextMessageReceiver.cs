using System;
using System.Threading;
using System.Threading.Tasks;
using Lime.Protocol;
using Takenet.MessagingHub.Client;
using Takenet.MessagingHub.Client.Listener;
using Takenet.MessagingHub.Client.Sender;
using System.Diagnostics;
using Lime.Messaging.Contents;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TeachingBlipSDK
{
    public class PlainTextMessageReceiver : IMessageReceiver
    {
        private readonly IMessagingHubSender _sender;
        private Settings _settings;
        public PlainTextMessageReceiver(IMessagingHubSender sender, Settings settings)
        {
            _settings = settings;
            _sender = sender;
            
        }

        public async Task ReceiveAsync(Message message, CancellationToken cancellationToken)
        {
            
            /*---------------------------------------------*/
            /*----------------Hello World.----------------*/
            /*---------------------------------------------*/
            //Trace.TraceInformation($"From: {message.From} \tContent: {message.Content}");
            //await _sender.SendMessageAsync("Pong!", message.From, cancellationToken);

            /*------------------------------------------*/
            /*----------Working with _settings----------*/
            /*------------------------------------------*/
            var text2 = _settings.setting1;

            /*---------------------------------------------*/
            /*-------------Sending text. 1.0---------------*/
            /*---------------------------------------------*/
            //var text = new PlainText
            //{
            //    Text = "... Inspiração, e um pouco de café! E isso me basta!"
            //};
            //await _sender.SendMessageAsync(text, message.From, cancellationToken);

            /*---------------------------------------------*/
            /*-------------Sending text. 2.0---------------*/
            /*---------------------------------------------*/
            //var text = new PlainText();
            //text.Text = "... Inspiração, e um pouco de café! E isso me basta!";
            //await _sender.SendMessageAsync(text, message.From, cancellationToken);

            /*---------------------------------------------*/
            /*---------------Sending text. 3.0-------------*/
            /*---------------------------------------------*/
            //var document = BlipSDKHelper.CreateText("... Inspiração, e um pouco de café! E isso me basta!");

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*---------------------------------------------*/
            /*----------Sending Image + text. 1.0----------*/
            /*---------------------------------------------*/
            //var document = new MediaLink
            //{
            //    Title = "ObrigatoryTitle",
            //    Text = "OptionalText",
            //    PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //    Type = MediaType.Parse("image/*"),
            //    Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg")
            //};
            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*---------------------------------------------*/
            /*----------Sending Image + text. 2.0----------*/
            /*---------------------------------------------*/
            //var document = new MediaLink();
            //document.Title = "ObrigatoryTitle";
            //document.Text = "OptionalText";
            //document.Type = MediaType.Parse("image/*");
            //document.PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //document.Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*---------------------------------------------*/
            /*----------Sending Image + text. 3.0----------*/
            /*---------------------------------------------*/
            //var document = BlipSDKHelper.CreateImage("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg", "ObrigatoryTitle", "OptionalText");
            //var document = BlipSDKHelper.CreateVideo("https://dl.dropboxusercontent.com/s/g407mwt2agivwu6/filmejogo%2024%20B.mp4", "title", "text");

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-------------------------------------------------*/
            /*--sending weblink(Image Or Video with link) 1.0--*/
            /*-------------------------------------------------*/
            //var document = new WebLink
            //{
            //    Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //    PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //    Title = "Obrigatory Title",
            //    Text = "Non Obrigatory Text"
            //};
            //await _sender.SendMessageAsync(document, message.From, cancellationToken);


            /*-------------------------------------------------*/
            /*--sending weblink(Image Or Video with link) 2.0--*/
            /*-------------------------------------------------*/
            //var document = new WebLink();
            //document.Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //document.PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //document.Title = "Obrigatory Title";
            //document.Text = "Non Obrigatory Text";
            //await _sender.SendMessageAsync(document, message.From, cancellationToken);


            /*-------------------------------------------------*/
            /*--sending weblink(Image Or Video with link) 3.0--*/
            /*-------------------------------------------------*/
            //var document = BlipSDKHelper.CreateImageWithLink("http://www.w3schools.com/css/img_fjords.jpg", "https://pixabay.com/p-1285634/?no_redirect", "Obrigatory text", "Non-Obrigatory text");

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-------------------------------------------------*/
            /*-------sending list of options (select) 1.0------*/
            /*-------------------------------------------------*/
            //It is grouped by 3. 
            //var document = new Select
            //{
            //    Text = "Menu Text",
            //    Options = new SelectOption[] 
            //    {
            //        new SelectOption
            //        {
            //            Text = "Option 1",
            //            Value = "Value 1",
            //            Order = 1
            //        },
            //        new SelectOption
            //        {
            //            Text = "Option 3",
            //            Value = "Value 3",
            //            Order = 3
            //        },
            //           new SelectOption
            //        {
            //            Text = "Option 2",
            //            Value = "Value 2",
            //            Order = 2
            //        }
            //    }
            //};

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-------------------------------------------------*/
            /*-------sending list of options (select) 2.0------*/
            /*-------------------------------------------------*/

            //var document = new Select();
            //document.Text = "MenuText";
            //document.Options = new SelectOption[3];

            //document.Options[0] = new SelectOption();
            //document.Options[0].Text = "Option 1";
            //document.Options[0].Value = "Value 1";
            //document.Options[0].Order = 1;

            //document.Options[1] = new SelectOption();
            //document.Options[1].Text = "Option 3";
            //document.Options[1].Value = "Value 3";
            //document.Options[1].Order = 3;

            //document.Options[2] = new SelectOption();
            //document.Options[2].Text = "Option 2";
            //document.Options[2].Value = "Value 2";
            //document.Options[2].Order = 2;

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-------------------------------------------------*/
            /*-------sending list of options (select) 3.0------*/
            /*-------------------------------------------------*/
            //It is grouped by 3. 
            //Dictionary<string, string> buttons = new Dictionary<string, string>();
            //buttons.Add("Botao1", "Value1");
            //buttons.Add("Botao2", "Value2");
            //var document = BlipSDKHelper.CreateListOfOptions("Escolha uma opção:", buttons);

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-------------------------------*/
            /*----creating quickreply 1.0----*/
            /*-------------------------------*/

            //var document = new DocumentSelect
            //{
            //    Header = new DocumentContainer
            //    {
            //        Value = new PlainText
            //        {
            //            Text = "Menu Text"
            //        }
            //    },
            //    Options = new DocumentSelectOption[] 
            //    {
            //        new DocumentSelectOption
            //        {
            //            Label = new DocumentContainer
            //            {
            //                Value = "Button 1",

            //            },
            //            Value = new DocumentContainer
            //            {
            //                Value = "Value 1"
            //            }
            //        },
            //        new DocumentSelectOption
            //        {
            //            Label = new DocumentContainer
            //            {
            //                Value = "Button 2",

            //            },
            //            Value = new DocumentContainer
            //            {
            //                Value = "Value 2"
            //            }
            //        },
            //        new DocumentSelectOption
            //        {
            //            Label = new DocumentContainer
            //            {
            //                Value = "Button 3",

            //            },
            //            Value = new DocumentContainer
            //            {
            //                Value = "Value 3"
            //            }
            //        }
            //    },
            //    Scope = SelectScope.Immediate

            //};
            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*---------------------------------------------------------*/
            /*----creating quickreply 1.1 - Sending Location Button----*/
            /*---------------------------------------------------------*/

            //var document = new DocumentSelect
            //{
            //    Header = new DocumentContainer
            //    {
            //        Value = new PlainText
            //        {
            //            Text = "Menu Text"
            //        }
            //    },
            //    Options = new DocumentSelectOption[]
            //    {
            //        new DocumentSelectOption
            //        {
            //            Label = new DocumentContainer
            //            {
            //                Value = "Button 1",

            //            },
            //            Value = new DocumentContainer
            //            {
            //                Value = "Value 1"
            //            }
            //        },
            //        new DocumentSelectOption
            //        {
            //            Label = new DocumentContainer
            //            {
            //                Value = new Input
            //                {
            //                    Validation = new InputValidation
            //                    {
            //                        Rule = InputValidationRule.Type,
            //                        Type = Location.MediaType
            //                    }
            //                }

            //            }
            //    }
            //    },
            //    Scope = SelectScope.Immediate
            //};
            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-------------------------------*/
            /*----creating quickreply 2.0----*/
            /*-------------------------------*/
            //DocumentSelect document = new DocumentSelect();
            //document.Header = new DocumentContainer();
            //document.Header.Value = new PlainText();
            //(document.Header.Value as PlainText).Text = "Menu Text";

            //document.Options = new DocumentSelectOption[2];

            //document.Options[0] = new DocumentSelectOption();
            //document.Options[0].Label = new DocumentContainer();
            //document.Options[0].Label.Value = "Button 1";
            //document.Options[0].Value = new DocumentContainer();
            //document.Options[0].Value.Value = "Value 1";

            //document.Options[1] = new DocumentSelectOption();
            //document.Options[1].Label = new DocumentContainer();
            //document.Options[1].Label.Value = new Input();
            //(document.Options[1].Label.Value as Input).Validation = new InputValidation();
            //(document.Options[1].Label.Value as Input).Validation.Rule = InputValidationRule.Type;
            //(document.Options[1].Label.Value as Input).Validation.Type = Location.MediaType;

            //document.Scope = SelectScope.Immediate;

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*----------------------------------*/
            /*------Creating quickreply 3.0-----*/
            /*----------------------------------*/
            //List<DocumentSelectOption> buttons = new List<DocumentSelectOption>();
            //buttons.Add(BlipSDKHelper.CreateQuickReplyDefaultButton("botão1", "bla"));
            //buttons.Add(BlipSDKHelper.CreateQuickReplyDefaultButton("botão2", "bla2"));
            //buttons.Add(BlipSDKHelper.CreateQuickReplySendLocationButton());
            //var document = BlipSDKHelper.CreateQuickReply($"Onde você está? 🙂\n\n📨Envie seu CEP, endereço ou localização", buttons);

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-----------------------------------------------------------*/
            /*--------Sending multiple things at the same time. 1.0------*/
            /*-----------------------------------------------------------*/

            //var document = new DocumentCollection
            //{
            //    ItemType = DocumentContainer.MediaType,
            //    Items = new Document[]
            //    {
            //            new DocumentContainer
            //            {
            //                Value = new PlainText
            //                        {
            //                            Text = "... Inspiração, e um pouco de café! E isso me basta!"
            //                        }
            //            },
            //            new DocumentContainer
            //            {
            //                Value = new WebLink
            //                        {
            //                            Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                            PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                            Title = "Obrigatory Title",
            //                            Text = "Non Obrigatory Text"
            //                        }
            //            }
            //    }
            //};
            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-----------------------------------------------------------*/
            /*--------Sending multiple things at the same time. 2.0------*/
            /*-----------------------------------------------------------*/

            //var document = new DocumentCollection();
            //document.ItemType = DocumentContainer.MediaType;
            //document.Items = new Document[2];

            //document.Items[0] = new DocumentContainer();
            //(document.Items[0] as DocumentContainer).Value = new PlainText();
            //((document.Items[0] as DocumentContainer).Value as PlainText).Text = "... Inspiração, e um pouco de café! E isso me basta!";

            //document.Items[1] = new DocumentContainer();
            //(document.Items[1] as DocumentContainer).Value = new WebLink();
            //((document.Items[1] as DocumentContainer).Value as WebLink).Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //((document.Items[1] as DocumentContainer).Value as WebLink).PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //((document.Items[1] as DocumentContainer).Value as WebLink).Title = "Obrigatory Title";
            //((document.Items[1] as DocumentContainer).Value as WebLink).Text = "Non Obrigatory Text";

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-----------------------------------------------------------*/
            /*--------Sending multiple things at the same time. 3.0------*/
            /*-----------------------------------------------------------*/

            //List<Document> content = new List<Document>();
            //content.Add(BlipSDKHelper.CreateText("First message"));
            //content.Add(BlipSDKHelper.CreateImage("http://www.amor.blog.br/imagens/imagens-de-amor-imagem-15.jpg", "Title"));
            //content.Add(BlipSDKHelper.CreateVideo("https://dl.dropboxusercontent.com/s/g407mwt2agivwu6/filmejogo%2024%20B.mp4"));
            //var document = BlipSDKHelper.CreateListOfDocuments(content);

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-------------------------------------------------------*/
            /*---------------------Carroussel. 1.0-------------------*/
            /*-------------------------------------------------------*/

            //var document = new DocumentCollection
            //{
            //    Items = new DocumentSelect[]
            //    {
            //        new DocumentSelect
            //        {
            //            Header = new DocumentContainer
            //            {
            //                Value = new MediaLink
            //                {
            //                    Title = "Obrigatory Text 1",
            //                    Text = "Optional Text 1",
            //                    PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                    Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg")
            //                }
            //            },

            //            Options = new DocumentSelectOption[]
            //            {
            //                new DocumentSelectOption
            //                {
            //                    Label = new DocumentContainer
            //                    {
            //                        Value = "Button 1"
            //                    },
            //                    Value = new DocumentContainer
            //                    {
            //                        Value = "Value 1"
            //                    }
            //                },
            //                new DocumentSelectOption
            //                {
            //                    Label = new DocumentContainer
            //                    {
            //                        Value = "Button 2"
            //                    },
            //                    Value = new DocumentContainer
            //                    {
            //                        Value = "Value 2"
            //                    }
            //                }
            //            }
            //        },

            //        new DocumentSelect
            //        {
            //            Header = new DocumentContainer
            //            {
            //                Value = new MediaLink
            //                {
            //                    Title = "Obrigatory Text 1",
            //                    Text = "Optional Text 1",
            //                    PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                    Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg")
            //                }
            //            },

            //            Options = new DocumentSelectOption[]
            //            {
            //                new DocumentSelectOption
            //                {
            //                    Label = new DocumentContainer
            //                    {
            //                        Value = "Button 1"
            //                    },
            //                    Value = new DocumentContainer
            //                    {
            //                        Value = "Value 1"
            //                    }
            //                },
            //                new DocumentSelectOption
            //                {
            //                    Label = new DocumentContainer
            //                    {
            //                        Value = "Button 2"
            //                    },
            //                    Value = new DocumentContainer
            //                    {
            //                        Value = "Value 2"
            //                    }
            //                }
            //            }
            //        }
            //    },
            //    ItemType = DocumentSelect.MediaType
            //};

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-------------------------------------------------------*/
            /*---------------------Carroussel. 2.0-------------------*/
            /*-------------------------------------------------------*/
            //var document = new DocumentCollection();
            //document.Items = new DocumentSelect[2];
            //document.ItemType = DocumentSelect.MediaType;

            //document.Items[0] = new DocumentSelect();
            //(document.Items[0] as DocumentSelect).Header = new DocumentContainer();
            //(document.Items[0] as DocumentSelect).Header.Value = new MediaLink();
            //((document.Items[0] as DocumentSelect).Header.Value as MediaLink).Title = "Obrigatory Title";
            //((document.Items[0] as DocumentSelect).Header.Value as MediaLink).Text = "Optional Text";
            //((document.Items[0] as DocumentSelect).Header.Value as MediaLink).Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //((document.Items[0] as DocumentSelect).Header.Value as MediaLink).PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Items[0] as DocumentSelect).Options = new DocumentSelectOption[2];
            //(document.Items[0] as DocumentSelect).Options[0] = new DocumentSelectOption();
            //(document.Items[0] as DocumentSelect).Options[0].Label = new DocumentContainer();
            //((document.Items[0] as DocumentSelect).Options[0].Label as DocumentContainer).Value = "Button 1";
            //(document.Items[0] as DocumentSelect).Options[0].Value = new DocumentContainer();
            //((document.Items[0] as DocumentSelect).Options[0].Value as DocumentContainer).Value = "Value 1";
            //(document.Items[0] as DocumentSelect).Options[1] = new DocumentSelectOption();
            //(document.Items[0] as DocumentSelect).Options[1].Label = new DocumentContainer();
            //((document.Items[0] as DocumentSelect).Options[1].Label as DocumentContainer).Value = "Button 2";
            //(document.Items[0] as DocumentSelect).Options[1].Value = new DocumentContainer();
            //((document.Items[0] as DocumentSelect).Options[1].Value as DocumentContainer).Value = "Value 2";

            //document.Items[1] = new DocumentSelect();
            //(document.Items[1] as DocumentSelect).Header = new DocumentContainer();
            //(document.Items[1] as DocumentSelect).Header.Value = new MediaLink();
            //((document.Items[1] as DocumentSelect).Header.Value as MediaLink).Title = "Obrigatory Title";
            //((document.Items[1] as DocumentSelect).Header.Value as MediaLink).Text = "Optional Text";
            //((document.Items[1] as DocumentSelect).Header.Value as MediaLink).Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //((document.Items[1] as DocumentSelect).Header.Value as MediaLink).PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Items[1] as DocumentSelect).Options = new DocumentSelectOption[2];
            //(document.Items[1] as DocumentSelect).Options[0] = new DocumentSelectOption();
            //(document.Items[1] as DocumentSelect).Options[0].Label = new DocumentContainer();
            //((document.Items[1] as DocumentSelect).Options[0].Label as DocumentContainer).Value = "Button 1";
            //(document.Items[1] as DocumentSelect).Options[0].Value = new DocumentContainer();
            //((document.Items[1] as DocumentSelect).Options[0].Value as DocumentContainer).Value = "Value 1";
            //(document.Items[1] as DocumentSelect).Options[1] = new DocumentSelectOption();
            //(document.Items[1] as DocumentSelect).Options[1].Label = new DocumentContainer();
            //((document.Items[1] as DocumentSelect).Options[1].Label as DocumentContainer).Value = "Button 2";
            //(document.Items[1] as DocumentSelect).Options[1].Value = new DocumentContainer();
            //((document.Items[1] as DocumentSelect).Options[1].Value as DocumentContainer).Value = "Value 2";

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*-----------------------------------------------------------*/
            /*---------------------Carroussel. 3.0-----------------------*/
            /*-----------------------------------------------------------*/

            //List<MediaLink> content = new List<MediaLink>();
            //content.Add(BlipSDKHelper.CreateCarrousselHeader("Title, Subtitle, Image and Buttons", "Image goes up above, Title goes above, Subtitle goes here and button goes below.", "http://www.w3schools.com/css/img_fjords.jpg"));
            //content.Add(BlipSDKHelper.CreateCarrousselHeader("Title, Subtitle and Button", "Title goes above, Subtitle goes here and button goes below.", ""));
            //content.Add(BlipSDKHelper.CreateCarrousselHeader("Title, Subtitle and Image", "Image goes up above, Title goes above and Subtitle goes here.", "http://www.w3schools.com/css/img_fjords.jpg"));
            //content.Add(BlipSDKHelper.CreateCarrousselHeader("Title, Image and Button: Image goes up above, Title goes here and button below", "", "http://www.w3schools.com/css/img_fjords.jpg"));
            //content.Add(BlipSDKHelper.CreateCarrousselHeader("Title and Image: Image goes up above, Title goes here", "", "http://www.w3schools.com/css/img_fjords.jpg"));
            //content.Add(BlipSDKHelper.CreateCarrousselHeader("Title and Subtitle", "Title goes above, Subtitle goes here", ""));
            //content.Add(BlipSDKHelper.CreateCarrousselHeader("Title and Button: Title goes here, button goes below", "", ""));

            //List<Button> buttons = new List<Button>();
            //buttons.Add(BlipSDKHelper.CreateCarrousselDefaultButton(BlipSDKHelper.CreateText("First button: Text"), 1, "bla", 0));
            //buttons.Add(BlipSDKHelper.CreateCarrousselDefaultButton(BlipSDKHelper.CreateLink("http://www.w3schools.com/css/img_fjords.jpg", "Second button: Link"), 0, "bla2", 0));
            //buttons.Add(BlipSDKHelper.CreateCarrousselDefaultButton(BlipSDKHelper.CreateText("Just a text"), 1, "bla3", 1));
            //buttons.Add(BlipSDKHelper.CreateCarrousselDefaultButton(BlipSDKHelper.CreateLink("http://www.w3schools.com/css/img_fjords.jpg", "Redirect to link"), 1, "bla4", 3));
            //buttons.Add(BlipSDKHelper.CreateCarrousselDefaultButton(BlipSDKHelper.CreateLink("http://www.w3schools.com/css/img_fjords.jpg", "Redirect to link"), 1, "bla5", 6));
            //buttons.Add(BlipSDKHelper.CreateCarrousselDefaultButton(BlipSDKHelper.CreateLink("http://www.facebook.com", "Redirect to link"), 2, "bla6", 6));

            //var document = BlipSDKHelper.CreateCarroussel(content, buttons);

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*---------------------------------------*/
            /*----------------List. 1.0--------------*/
            /*---------------------------------------*/
            //Header não é obrigatório.
            //O maximo de elementos (Header + Lista) é igual a 4.

            //var document = new DocumentList
            //{
            //    Header = new DocumentContainer
            //    {
            //        Value = new WebLink
            //        {
            //            Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //            PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //            Title = "Obrigatory Title",
            //            Text = "Non Obrigatory Text"
            //        }
            //    },
            //    Items = new DocumentContainer[] 
            //    {
            //        new DocumentContainer
            //        {
            //              Value = new WebLink
            //                {
            //                    Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                    PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                    Title = "Obrigatory Title",
            //                    Text = "Non Obrigatory Text"
            //                }
            //        },
            //         new DocumentContainer
            //        {
            //              Value = new WebLink
            //                {
            //                    Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                    PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                    Title = "Obrigatory Title",
            //                    Text = "Non Obrigatory Text"
            //                }
            //        },
            //          new DocumentContainer
            //        {
            //              Value = new WebLink
            //                {
            //                    Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                    PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //                    Title = "Obrigatory Title",
            //                    Text = "Non Obrigatory Text"
            //                }

            //        }

            //    }

            //};

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*---------------------------------------*/
            /*----------------List. 2.0--------------*/
            /*---------------------------------------*/
            //Header não é obrigatório.
            //O Mínimo de elementos (Header + Lista) é igual a 2.
            //O Máximo de elementos (Header + Lista) é igual a 4.


            //var document = new DocumentList();
            //document.Header = new DocumentContainer();
            //document.Header.Value = new WebLink();
            //(document.Header.Value as WebLink).Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Header.Value as WebLink).PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Header.Value as WebLink).Title = "Obrigatory Title";
            //(document.Header.Value as WebLink).Text = "Non Obrigatory Text";
            //document.Items = new DocumentContainer[3];
            //document.Items[0] = new DocumentContainer();
            //document.Items[0].Value = new WebLink();
            //(document.Items[0].Value as WebLink).Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Items[0].Value as WebLink).PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Items[0].Value as WebLink).Title = "Obrigatory Title";
            //(document.Items[0].Value as WebLink).Text = "Non Obrigatory Text";
            //document.Items[1] = new DocumentContainer();
            //document.Items[1].Value = new WebLink();
            //(document.Items[1].Value as WebLink).Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Items[1].Value as WebLink).PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Items[1].Value as WebLink).Title = "Obrigatory Title";
            //(document.Items[1].Value as WebLink).Text = "Non Obrigatory Text";
            //document.Items[2] = new DocumentContainer();
            //document.Items[2].Value = new WebLink();
            //(document.Items[2].Value as WebLink).Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Items[2].Value as WebLink).PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //(document.Items[2].Value as WebLink).Title = "Obrigatory Title";
            //(document.Items[2].Value as WebLink).Text = "Non Obrigatory Text";

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*---------------------------------------*/
            /*----------------List. 3.0--------------*/
            /*---------------------------------------*/

            //var content = new List<WebLink>();
            //content.Add(BlipSDKHelper.CreateImageWithLink("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg", "http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg", "Title", "Text"));
            //content.Add(BlipSDKHelper.CreateImageWithLink("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg", "http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg", "Title", "Text"));
            //var document = BlipSDKHelper.CreateList(content);

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

            /*---------------------------------------*/
            /*-------------Receipt Payment-----------*/
            /*---------------------------------------*/
            //Update BlipSDK para aceitar Address.
            //Fazer funcionar o Address.

            //var document = new PaymentReceipt
            //{
            //    Code = Guid.NewGuid().ToString(),
            //    PaidOn = DateTime.Now,
            //    Currency = "BRL",
            //    Total = decimal.Parse((10.85).ToString()),
            //    Method = new PaymentMethod
            //    {
            //        //Name = PaymentMethod.NAME_KEY,
            //        //Account = PaymentMethod.ACCOUNT_KEY
            //        Name = "Cartão de Crédito",
            //        Account = "Blablabla"

            //    },
            //    Taxes = decimal.Parse((10.85).ToString()),
            //    Address = new PaymentAddress
            //    {
            //        City = "Belo Horizonte",
            //        Country = "Brasil",
            //        PostalCode = "31313313",
            //        State = "Minas Gerais",
            //        Street = "Rua blablabla N 123 Bairro Bla"
            //    },
            //    Items = new InvoiceItem[]{
            //        new InvoiceItem
            //        {
            //            Quantity = 1,
            //            Unit = decimal.Parse((10.85).ToString()),
            //            Currency = "BRL",
            //            Total = decimal.Parse((10.85).ToString()),
            //            Description = "Some description",
            //            Taxes = decimal.Parse((10.85).ToString()),
            //            ImageUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg"),
            //            ImageType = WebLink.MediaType,
            //            Complement = "bla"
            //        }

            //    }


            //};

            //await _sender.SendMessageAsync(document, message.From, cancellationToken);

        }
        
    }
}
