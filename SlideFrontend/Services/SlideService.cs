using SlideFrontend.Components.Slides;
using SlideFrontend.Models;

namespace SlideFrontend.Services
{
    public class SlideService
    {
        public List<SlideInfo> GetSlides()
        {
            return new List<SlideInfo>
            {
                new SlideInfo { Title = "Explaining Blazor", ComponentType = typeof(Slide01_ExplainingBlazor) },
                new SlideInfo { Title = "What We'll Cover", ComponentType = typeof(Slide02_WhatWellCover) },
                new SlideInfo { Title = "What is Blazor? (An Easy Explanation)", ComponentType = typeof(Slide03_WhatIsBlazorEasy) },
                new SlideInfo { Title = "What is Blazor? (The Technical Side)", ComponentType = typeof(Slide04_WhatIsBlazorTechnical) },
                new SlideInfo { Title = "How Blazor Runs: Hosting Models", ComponentType = typeof(Slide05_HostingModels) },
                new SlideInfo { Title = "Running on the Server", ComponentType = typeof(Slide06_RunningOnServer) },
                new SlideInfo { Title = "Running in the Browser", ComponentType = typeof(Slide07_RunningInBrowser) },
                new SlideInfo { Title = "Server vs. WebAssembly (WASM)", ComponentType = typeof(Slide08_ServerVsWasm) },
                new SlideInfo { Title = "The Next Step: Mixing Render Modes", ComponentType = typeof(Slide09_MixingRenderModes) },
                new SlideInfo { Title = "Blazor vs. Old HTML Pages", ComponentType = typeof(Slide10_VsOldHtml) },
                new SlideInfo { Title = "Blazor vs. JavaScript Frameworks", ComponentType = typeof(Slide11_VsJsFrameworks) },
                new SlideInfo { Title = "Main Differences", ComponentType = typeof(Slide12_MainDifferences) },
                new SlideInfo { Title = "What is Middleware?", ComponentType = typeof(Slide13_WhatIsMiddleware) },
                new SlideInfo { Title = "The Middleware Pipeline in Action", ComponentType = typeof(Slide14_MiddlewarePipeline) },
                new SlideInfo { Title = "The Magic of Data Binding", ComponentType = typeof(Slide15_DataBindingMagic) },
                new SlideInfo { Title = "How Data Binding Works", ComponentType = typeof(Slide16_HowDataBindingWorks) },
                new SlideInfo { Title = "How @bind Works Inside", ComponentType = typeof(Slide17_HowBindWorks) },
                new SlideInfo { Title = "Summary", ComponentType = typeof(Slide18_Summary) },
                new SlideInfo { Title = "Questions?", ComponentType = typeof(Slide19_Questions) }
            };
        }
    }
}