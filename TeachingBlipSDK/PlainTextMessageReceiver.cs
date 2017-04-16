using System;
using System.Threading;
using System.Threading.Tasks;
using Lime.Protocol;
using Takenet.MessagingHub.Client;
using Takenet.MessagingHub.Client.Listener;
using Takenet.MessagingHub.Client.Sender;
using System.Diagnostics;
using Lime.Messaging.Contents;

namespace TeachingBlipSDK
{
    public class PlainTextMessageReceiver : IMessageReceiver
    {
        private readonly IMessagingHubSender _sender;

        public PlainTextMessageReceiver(IMessagingHubSender sender)
        {
            _sender = sender;
        }

        public async Task ReceiveAsync(Message message, CancellationToken cancellationToken)
        {

            /*---------------------------------------------*/
            /*----------------Hello World.----------------*/
            /*---------------------------------------------*/
            //Trace.TraceInformation($"From: {message.From} \tContent: {message.Content}");
            //await _sender.SendMessageAsync("Pong!", message.From, cancellationToken);

            /*---------------------------------------------*/
            /*-------------Sending text. 1.0---------------*/
            /*---------------------------------------------*/
            //var text = new PlainText
            //{
            //    Text = "... Inspira��o, e um pouco de caf�! E isso me basta!"
            //};
            //await _sender.SendMessageAsync(text, message.From, cancellationToken);

            /*---------------------------------------------*/
            /*-------------Sending text. 2.0---------------*/
            /*---------------------------------------------*/
            //var text = new PlainText();
            //text.Text = "... Inspira��o, e um pouco de caf�! E isso me basta!";
            //await _sender.SendMessageAsync(text, message.From, cancellationToken);

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
            //                            Text = "... Inspira��o, e um pouco de caf�! E isso me basta!"
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
            //((document.Items[0] as DocumentContainer).Value as PlainText).Text = "... Inspira��o, e um pouco de caf�! E isso me basta!";

            //document.Items[1] = new DocumentContainer();
            //(document.Items[1] as DocumentContainer).Value = new WebLink();
            //((document.Items[1] as DocumentContainer).Value as WebLink).Uri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //((document.Items[1] as DocumentContainer).Value as WebLink).PreviewUri = new Uri("http://www.jqueryscript.net/images/Simplest-Responsive-jQuery-Image-Lightbox-Plugin-simple-lightbox.jpg");
            //((document.Items[1] as DocumentContainer).Value as WebLink).Title = "Obrigatory Title";
            //((document.Items[1] as DocumentContainer).Value as WebLink).Text = "Non Obrigatory Text";

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


        }

    }
}
