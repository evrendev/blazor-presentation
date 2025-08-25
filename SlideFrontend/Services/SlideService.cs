using SlideFrontend.Models;

namespace SlideFrontend.Services
{
    public class SlideService
    {
        public List<SlideData> GetSlides()
        {
            return new List<SlideData>
            {
                new SlideData
                {
                    Title = "Explaining Blazor",
                    Content = @"
                        <h1 class=""text-4xl sm:text-5xl md:text-7xl font-bold text-blue-700 mb-4"">Explaining Blazor</h1>
                        <p class=""text-xl sm:text-2xl md:text-3xl text-gray-600"">What Professionals Need to Know</p>
                    ",
                    Notes = @"
                        <h3 class=""font-bold text-lg mb-2"">Introduction</h3>
                        <p>My goal today is to explain Blazor in a way that is clear for people who are not experts, but still correct for those with software knowledge.</p>
                        <p>We'll cover what Blazor is, how it compares to other web technologies, and look at two of its key features. This will give you a good understanding of why Blazor is an important technology.</p>
                    "
                },
                new SlideData
                {
                    Title = "What We'll Cover",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8 md:mb-12"">What We'll Cover</h2>
                        <ol class=""text-left text-xl sm:text-2xl md:text-3xl space-y-4 md:space-y-6"">
                            <li class=""flex items-center""><span class=""text-blue-600 font-bold mr-4"">1.</span> What is Blazor?</li>
                            <li class=""flex items-center""><span class=""text-blue-600 font-bold mr-4"">2.</span> Blazor vs. Other Web Technologies</li>
                            <li class=""flex items-center""><span class=""text-blue-600 font-bold mr-4"">3.</span> The Role of Middleware</li>
                            <li class=""flex items-center""><span class=""text-blue-600 font-bold mr-4"">4.</span> The Power of Data Binding</li>
                        </ol>
                    ",
                    Notes = @"
                        <p>We will talk about these four key areas. We'll start with the basics of Blazor. Then, we'll compare it to other technologies you may know. Finally, we'll look at two key technical ideas—Middleware and Data Binding—to understand how Blazor apps work.</p>
                    "
                },
                new SlideData
                {
                    Title = "What is Blazor? (An Easy Explanation)",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8"">What is Blazor?</h2>
                        <p class=""text-xl sm:text-2xl text-gray-600 mb-8 md:mb-12"">The ""Translator"" for Web Development</p>
                        <div class=""flex flex-col sm:flex-row items-center justify-center gap-4 text-base sm:text-xl w-full"">
                            <div class=""bg-blue-100 text-blue-800 p-4 rounded-lg shadow-md""><strong>C# Code</strong><br/>(Your Logic)</div>
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""text-gray-500 rotate-90 sm:rotate-0""><path d=""m5 12 7-7 7 7""/><path d=""m5 19 7-7 7 7""/></svg>
                            <div class=""bg-gray-700 text-white p-4 rounded-lg shadow-md""><strong>WebAssembly</strong><br/>(The Translator)</div>
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""text-gray-500 rotate-90 sm:rotate-0""><path d=""m5 12 7-7 7 7""/><path d=""m5 19 7-7 7 7""/></svg>
                            <div class=""bg-green-100 text-green-800 p-4 rounded-lg shadow-md""><strong>Web Browser</strong><br/>(Runs Everywhere)</div>
                        </div>
                    ",
                    Notes = @"
                        <h3 class=""font-bold text-lg mb-2"">An Easy Explanation</h3>
                        <p>Imagine your C# developers are engineers who only speak German. The web browser, however, only understands Japanese (which is JavaScript). Before, you needed a separate team of Japanese-speaking engineers for the user interface.</p>
                        <p>Blazor is a powerful translator. It lets your German-speaking C# engineers write everything in their own language. Blazor then translates this into something the browser can understand and run very fast. This means one team, using one language, can build the whole application. This makes everything more efficient.</p>
                    "
                },
                new SlideData
                {
                    Title = "What is Blazor? (The Technical Side)",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8 md:mb-12"">A Modern Web Framework</h2>
                        <div class=""flex flex-col sm:flex-row items-center justify-center gap-4 sm:gap-8 text-lg sm:text-xl"">
                            <div class=""text-center"">
                                <div class=""bg-white p-4 sm:p-6 rounded-lg shadow-lg border border-gray-200"">
                                    <p class=""font-mono text-blue-600"">&lt;MyComponent.razor&gt;</p>
                                    <p class=""text-gray-500 mt-2 text-sm sm:text-base"">HTML + C#</p>
                                </div>
                            </div>
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""32"" height=""32"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""text-gray-500 rotate-90 sm:rotate-0""><path d=""M17 8L21 12L17 16""/><path d=""M3 12H21""/></svg>
                            <div class=""text-center"">
                                <div class=""bg-white p-4 sm:p-6 rounded-lg shadow-lg border border-gray-200"">
                                    <p class=""font-semibold text-green-700"">Interactive UI</p>
                                    <p class=""text-gray-500 mt-2 text-sm sm:text-base"">Reusable Parts</p>
                                </div>
                            </div>
                        </div>
                        <div class=""mt-8 md:mt-12 text-lg sm:text-xl md:text-2xl space-y-3 md:space-y-4"">
                            <p>✓ Build modern web apps with .NET</p>
                            <p>✓ Share code between client and server</p>
                            <p>✓ Use the large .NET ecosystem</p>
                        </div>
                    ",
                    Notes = @"
                        <h3 class=""font-bold text-lg mb-2"">The Technical Details</h3>
                        <p>Technically, Blazor is a framework for building interactive web apps using C# instead of JavaScript. It is part of ASP.NET Core.</p>
                        <p>Apps are built from reusable parts of the UI called Razor Components. These components mix HTML and C# code. When data in a component changes, Blazor smartly updates only the parts of the page that change. This is efficient and means the whole page doesn't need to reload.</p>
                    "
                },
                new SlideData
                {
                    Title = "How Blazor Runs: Hosting Models",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8 md:mb-12"">How Blazor Runs: Hosting Models</h2>
                        <p class=""text-lg sm:text-xl md:text-2xl text-gray-600 mb-8 md:mb-12"">A key decision that defines how your app works.</p>
                        <div class=""grid grid-cols-1 md:grid-cols-2 gap-4 md:gap-8 w-full max-w-4xl"">
                            <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200 text-center"">
                                <h3 class=""text-2xl md:text-3xl font-semibold text-blue-700 mb-4"">Blazor Server</h3>
                                <p class=""text-base md:text-lg"">Code runs on the server.</p>
                                <p class=""text-base md:text-lg"">UI updates sent over a live connection.</p>
                            </div>
                            <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200 text-center"">
                                <h3 class=""text-2xl md:text-3xl font-semibold text-green-700 mb-4"">Blazor WebAssembly</h3>
                                <p class=""text-base md:text-lg"">Code runs in the browser.</p>
                                <p class=""text-base md:text-lg"">A true client-side app.</p>
                            </div>
                        </div>
                    ",
                    Notes = @"
                        <p>When you start a Blazor project, you must choose a hosting model. This is a very important decision for how fast the app is, how secure it is, and where it runs. The two main models are Blazor Server and Blazor WebAssembly. Let's look at an example for each.</p>
                    "
                },
                new SlideData
                {
                    Title = "Running on the Server",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8"">Running on the Server</h2>
                        <p class=""text-lg sm:text-xl md:text-2xl text-gray-600 mb-8 md:mb-12"">Example: A Remote-Controlled Car</p>
                        <div class=""flex flex-col sm:flex-row items-center justify-center gap-4 w-full max-w-5xl text-center"">
                            <div class=""flex flex-col items-center"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""60"" height=""60"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""text-gray-700 mb-4""><rect x=""2"" y=""3"" width=""20"" height=""14"" rx=""2"" ry=""2""></rect><line x1=""8"" y1=""21"" x2=""16"" y2=""21""></line><line x1=""12"" y1=""17"" x2=""12"" y2=""21""></line></svg>
                                <span class=""font-semibold text-lg sm:text-xl"">Browser (Simple Client)</span>
                            </div>
                            <div class=""flex flex-col items-center text-blue-600 font-semibold text-base sm:text-lg"">
                                <span>User Clicks →</span>
                                <div class=""w-32 sm:w-48 h-1 bg-blue-500 my-2""></div>
                                <div class=""w-32 sm:w-48 h-1 bg-gray-400 my-2""></div>
                                <span>← UI Updates</span>
                                <span class=""text-xs sm:text-sm mt-2"">(SignalR Connection)</span>
                            </div>
                            <div class=""flex flex-col items-center"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""60"" height=""60"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""text-blue-700 mb-4""><path d=""M12 22s8-4 8-10V5l-8-3-8 3v7c0 6 8 10 8 10z""></path></svg>
                                <span class=""font-semibold text-lg sm:text-xl"">Server (.NET App)</span>
                                <span class=""text-gray-600 text-sm sm:text-base"">All logic runs here</span>
                            </div>
                        </div>
                    ",
                    Notes = @"
                        <p>Think of Blazor Server like a remote-controlled car. The car (the user's browser) is simple. All the smart work happens in the remote control (the server). Commands are sent over a constant, live connection (a SignalR connection).</p>
                        <p>Technically, the C# code runs on the server. When a user clicks a button, the event is sent to the server. The server processes it, calculates the UI change, and sends a small update back to the browser. This is great for security because your code never leaves the server, and the app loads very fast the first time.</p>
                    "
                },
                new SlideData
                {
                    Title = "Running in the Browser",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8"">Running in the Browser</h2>
                        <p class=""text-lg sm:text-xl md:text-2xl text-gray-600 mb-8 md:mb-12"">Example: A LEGO Kit</p>
                        <div class=""flex flex-col items-center justify-center w-full max-w-5xl text-center"">
                            <div class=""flex flex-col sm:flex-row items-center text-base sm:text-lg mb-8"">
                                <span class=""font-semibold mb-2 sm:mb-0"">Initial Download:</span>
                                <div class=""ml-0 sm:ml-4 flex flex-wrap justify-center gap-2"">
                                    <div class=""bg-green-200 text-green-800 px-3 py-1 rounded text-sm"">.NET Runtime</div>
                                    <div class=""bg-green-200 text-green-800 px-3 py-1 rounded text-sm"">App Code</div>
                                    <div class=""bg-green-200 text-green-800 px-3 py-1 rounded text-sm"">Other Files</div>
                                </div>
                            </div>
                            <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200 w-full"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""60"" height=""60"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""text-green-700 mx-auto mb-4""><rect x=""2"" y=""3"" width=""20"" height=""14"" rx=""2"" ry=""2""></rect><line x1=""8"" y1=""21"" x2=""16"" y2=""21""></line><line x1=""12"" y1=""17"" x2=""12"" y2=""21""></line></svg>
                                <h3 class=""font-semibold text-xl sm:text-2xl"">Entire App Runs Inside the Browser</h3>
                                <p class=""text-gray-600 mt-2 text-sm sm:text-base"">Works offline, very fast interaction, can be hosted anywhere.</p>
                            </div>
                        </div>
                    ",
                    Notes = @"
                        <p>Blazor WebAssembly is like a big LEGO kit. The first download is like a big box with all the pieces and instructions. It might take a moment to download. But once you have it, you can build and use it all in your browser, even if your internet goes out.</p>
                        <p>Technically, your application's code is downloaded and run directly in the browser using WebAssembly. This allows apps to work offline and makes them very fast for hard tasks. After the first download, user actions are instant because there is no waiting for the network.</p>
                    "
                },
                new SlideData
                {
                    Title = "Server vs. WebAssembly (WASM)",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8 md:mb-12"">Server vs. WebAssembly (WASM)</h2>
                        <div class=""w-full max-w-5xl bg-white p-4 sm:p-8 rounded-lg shadow-lg border border-gray-200"">
                            <table class=""w-full text-left text-sm sm:text-lg md:text-xl responsive-table"">
                                <thead>
                                    <tr class=""border-b-2 border-gray-300"">
                                        <th class=""py-2 sm:py-3 px-2"">Feature</th>
                                        <th class=""py-2 sm:py-3 px-2 text-center"">Blazor Server</th>
                                        <th class=""py-2 sm:py-3 px-2 text-center"">Blazor WebAssembly</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr class=""border-b border-gray-200""><td data-label=""Feature"" class=""py-2 sm:py-3 px-2 font-semibold"">Initial Load</td><td data-label=""Blazor Server"" class=""py-3 px-2 text-center text-green-600"">Fast</td><td data-label=""Blazor WebAssembly"" class=""py-3 px-2 text-center text-orange-500"">Slower</td></tr>
                                    <tr class=""border-b border-gray-200""><td data-label=""Feature"" class=""py-2 sm:py-3 px-2 font-semibold"">User Interaction</td><td data-label=""Blazor Server"" class=""py-3 px-2 text-center text-orange-500"">Slower</td><td data-label=""Blazor WebAssembly"" class=""py-3 px-2 text-center text-green-600"">Very Fast</td></tr>
                                    <tr class=""border-b border-gray-200""><td data-label=""Feature"" class=""py-2 sm:py-3 px-2 font-semibold"">Offline Support</td><td data-label=""Blazor Server"" class=""py-3 px-2 text-center text-red-600"">No</td><td data-label=""Blazor WebAssembly"" class=""py-3 px-2 text-center text-green-600"">Yes</td></tr>
                                    <tr class=""border-b border-gray-200""><td data-label=""Feature"" class=""py-2 sm:py-3 px-2 font-semibold"">Security (App Code)</td><td data-label=""Blazor Server"" class=""py-3 px-2 text-center text-green-600"">High</td><td data-label=""Blazor WebAssembly"" class=""py-3 px-2 text-center text-orange-500"">Lower</td></tr>
                                    <tr><td data-label=""Feature"" class=""py-2 sm:py-3 px-2 font-semibold"">Best For</td><td data-label=""Blazor Server"" class=""py-3 px-2 text-center"">Internal Company Apps</td><td data-label=""Blazor WebAssembly"" class=""py-3 px-2 text-center"">Public Apps, Offline Apps</td></tr>
                                </tbody>
                            </table>
                        </div>
                    ",
                    Notes = @"
                        <p>This table shows the main differences. There is no single ""best"" model. The best choice depends on what the app needs to do. Blazor Server is great for internal company apps where security is very important. Blazor WebAssembly is great for public apps that need to be very fast and work offline.</p>
                    "
                },
                new SlideData
                {
                    Title = "The Next Step: Mixing Render Modes",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8"">The Next Step: Mixing Render Modes</h2>
                        <p class=""text-lg sm:text-xl md:text-2xl text-gray-600 mb-8 md:mb-12"">With .NET 8, you can use both.</p>
                        <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200 w-full max-w-4xl"">
                            <h3 class=""text-2xl md:text-3xl font-semibold mb-6 text-center"">Blazor Web App (.NET 8+)</h3>
                            <div class=""grid grid-cols-1 sm:grid-cols-2 gap-4 md:gap-6 text-base md:text-xl"">
                                <div class=""bg-gray-100 p-4 rounded""><strong>Static:</strong> For simple content pages.</div>
                                <div class=""bg-blue-100 p-4 rounded""><strong>Interactive Server:</strong> The classic Server model.</div>
                                <div class=""bg-green-100 p-4 rounded""><strong>Interactive WASM:</strong> The classic WebAssembly model.</div>
                                <div class=""bg-purple-100 p-4 rounded""><strong>Interactive Auto:</strong> Server first, then WASM.</div>
                            </div>
                            <p class=""text-center mt-6 text-base sm:text-lg md:text-xl text-gray-700"">Choose the best render mode <strong>for each page or component</strong>.</p>
                        </div>
                    ",
                    Notes = @"
                        <p>The choice between Server and WASM was a problem in older versions. The new Blazor Web App model in .NET 8 solves this. It brings the models together and lets a developer choose the render mode for each part of the page.</p>
                        <p>For example, a public landing page can be static for fast loading, while a complex dashboard can use WebAssembly. The ""Auto"" mode is very smart: it loads the page instantly using the Server model, while downloading the WebAssembly parts in the background for next time. This gives you the best parts of both models.</p>
                    "
                },
                new SlideData
                {
                    Title = "Blazor vs. Old HTML Pages",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8 md:mb-12"">More Than Just a Static Page</h2>
                        <div class=""grid grid-cols-1 md:grid-cols-2 gap-4 md:gap-8 w-full max-w-5xl"">
                            <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200"">
                                <h3 class=""text-xl sm:text-2xl font-semibold mb-4"">Static HTML</h3>
                                <p class=""text-base md:text-lg text-gray-600"">Request → Full Page Reload</p>
                                <p class=""mt-4 text-sm sm:text-base"">A simple experience where every click reloads the page.</p>
                            </div>
                            <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border-2 border-blue-500"">
                                <h3 class=""text-xl sm:text-2xl font-semibold mb-4"">Blazor (SPA)</h3>
                                <p class=""text-base md:text-lg text-gray-600"">Initial Load → Smart UI Updates</p>
                                <p class=""mt-4 text-sm sm:text-base"">An interactive experience like a desktop app, with no page reloads.</p>
                            </div>
                        </div>
                    ",
                    Notes = @"
                        <p>The difference between Blazor and old HTML sites is very big. Static sites reload the entire page every time you click a link. The page doesn't remember anything.</p>
                        <p>Blazor is a Single-Page Application (SPA). It loads the app once, then updates the UI without reloading. This avoids annoying page reloads. Blazor can also remember information, like data in a form, which allows for a much better user experience.</p>
                    "
                },
                new SlideData
                {
                    Title = "Blazor vs. JavaScript Frameworks",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8"">Blazor vs. JavaScript Frameworks</h2>
                        <p class=""text-lg sm:text-xl md:text-2xl text-gray-600 mb-8 md:mb-12"">A Strategic Choice for Your Team</p>
                        <div class=""flex flex-col sm:flex-row items-center justify-center gap-8 w-full max-w-5xl"">
                            <div class=""text-center p-6 bg-white rounded-lg shadow-lg border border-gray-200"">
                                <h3 class=""text-xl sm:text-2xl font-semibold mb-4"">Blazor</h3>
                                <p class=""text-5xl sm:text-7xl mb-4"">🇨#</p>
                                <p class=""text-sm sm:text-base"">.NET Ecosystem</p>
                                <p class=""text-sm sm:text-base"">One Technology Stack</p>
                                <p class=""text-sm sm:text-base"">Strongly-Typed</p>
                            </div>
                            <div class=""text-3xl sm=text-5xl font-bold text-gray-400"">vs.</div>
                            <div class=""text-center p-6 bg-white rounded-lg shadow-lg border border-gray-200"">
                                <h3 class=""text-xl sm:text-2xl font-semibold mb-4"">Vue.js / React</h3>
                                <p class=""text-5xl sm:text-7xl mb-4"">📜</p>
                                <p class=""text-sm sm:text-base"">JavaScript Ecosystem</p>
                                <p class=""text-sm sm:text-base"">Separate Stacks</p>
                                <p class=""text-sm sm:text-base"">Flexible Typing</p>
                            </div>
                        </div>
                    ",
                    Notes = @"
                        <p>Choosing between Blazor and JavaScript frameworks like Vue.js is not just a technical decision. It's about choosing the best tool for your team's skills.</p>
                        <p>If a company has a lot of experience with Microsoft tools and C#, then Blazor is a natural choice. It's an easy and productive choice because they can reuse their skills and code.</p>
                        <p>If a company has strong skills in JavaScript, then a framework like Vue.js is a better choice. The decision is about matching the technology to the team's strengths.</p>
                    "
                },
                new SlideData
                {
                    Title = "Main Differences",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8 md:mb-12"">Main Differences</h2>
                        <div class=""grid grid-cols-1 md:grid-cols-3 gap-4 md:gap-8 w-full max-w-6xl text-center"">
                            <div class=""bg-white p-6 rounded-lg shadow-lg border border-gray-200"">
                                <h3 class=""text-xl sm:text-2xl font-semibold mb-4"">Productivity</h3>
                                <p class=""text-sm sm:text-base"">Blazor lets .NET teams use C# for everything. This means they write less repeated code and work faster.</p>
                            </div>
                            <div class=""bg-white p-6 rounded-lg shadow-lg border border-gray-200"">
                                <h3 class=""text-xl sm:text-2xl font-semibold mb-4"">Performance</h3>
                                <p class=""text-sm sm:text-base"">JS frameworks usually load faster the first time. Blazor WASM is faster for heavy calculation tasks.</p>
                            </div>
                            <div class=""bg-white p-6 rounded-lg shadow-lg border border-gray-200"">
                                <h3 class=""text-xl sm:text-2xl font-semibold mb-4"">Ecosystem</h3>
                                <p class=""text-sm sm:text-base"">The JavaScript library ecosystem is very large. Blazor's is smaller but growing, and can use any standard .NET library.</p>
                            </div>
                        </div>
                    ",
                    Notes = @"
                        <p>To summarize: Blazor's main benefit is productivity for .NET teams, because they can share code and use one language.</p>
                        <p>For performance, it's a trade-off. JS frameworks are often faster to load. Blazor WebAssembly is faster for heavy calculations.</p>
                        <p>Finally, the JavaScript ecosystem of libraries is larger, but Blazor can use the entire, massive .NET library ecosystem, which is a huge advantage.</p>
                    "
                },
                new SlideData
                {
                    Title = "What is Middleware?",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8"">What is Middleware?</h2>
                        <p class=""text-lg sm:text-xl md:text-2xl text-gray-600 mb-8 md:mb-12"">An ASP.NET Core Idea: A Security Checkpoint</p>
                        <div class=""flex items-center justify-center w-full max-w-6xl bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200"">
                            <span class=""text-base sm:text-xl font-bold hidden sm:block"">Request →</span>
                            <div class=""flex-grow flex flex-wrap justify-center items-center gap-2 mx-2 sm:mx-4 p-2"">
                                <div class=""bg-gray-200 px-3 py-1 rounded-full text-xs sm:text-sm"">Logging</div>
                                <div class=""bg-gray-200 px-3 py-1 rounded-full text-xs sm:text-sm"">Authentication</div>
                                <div class=""bg-gray-200 px-3 py-1 rounded-full text-xs sm:text-sm"">Authorization</div>
                                <div class=""bg-gray-200 px-3 py-1 rounded-full text-xs sm:text-sm"">Routing</div>
                            </div>
                            <span class=""text-base sm:text-xl font-bold hidden sm:block"">→ Your App Code</span>
                        </div>
                    ",
                    Notes = @"
                        <p>Middleware is not a Blazor-specific feature. It's a basic and important pattern in ASP.NET Core, the framework that runs Blazor Server apps.</p>
                        <p>The best example is a series of security checkpoints. A request to your app is like a person trying to enter a secure building. They must go through a series of checks in a specific order. Each check is a piece of middleware. One check might look for errors, another might check security. Each check looks at the request and decides if it can continue.</p>
                    "
                },
                new SlideData
                {
                    Title = "The Middleware Pipeline in Action",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8 md:mb-12"">How the Request Pipeline Works</h2>
                        <div class=""w-full max-w-2xl bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200"">
                            <h3 class=""text-xl sm:text-2xl font-semibold mb-6"">The Order is Very Important</h3>
                            <ol class=""space-y-3 text-base sm:text-lg list-decimal list-inside"">
                                <li><code>UseExceptionHandler</code> - Catch errors first.</li>
                                <li><code>UseHttpsRedirection</code> - Use secure connections.</li>
                                <li><code>UseStaticFiles</code> - Serve files like CSS/images (fast).</li>
                                <li><code>UseRouting</code> - Decide where the request goes.</li>
                                <li><code>UseAuthentication</code> - Check <strong>who</strong> the user is.</li>
                                <li><code>UseAuthorization</code> - Check <strong>what</strong> the user can do.</li>
                                <li><code>MapBlazorHub</code> - Connect to the Blazor app.</li>
                            </ol>
                        </div>
                    ",
                    Notes = @"
                        <p>This is a simple view of a middleware pipeline. The order is very important. For example, you must check who a user is (Authentication) before you check what they can do (Authorization).</p>
                        <p>Middleware also makes things faster by ending the process early. For a simple request for an image, the Static Files middleware handles it and sends the response. The request doesn't need to go through the slower security checks, which is very efficient.</p>
                    "
                },
                new SlideData
                {
                    Title = "The Magic of Data Binding",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8"">The Magic of Data Binding</h2>
                        <p class=""text-lg sm:text-xl md:text-2xl text-gray-600 mb-8 md:mb-12"">Keeping UI and Code in Sync Automatically</p>
                        <div class=""flex flex-col sm:flex-row items-center justify-center gap-8 w-full max-w-4xl"">
                            <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200 text-center"">
                                <p class=""text-base sm:text-lg font-mono text-blue-700"">private string name = ""Ulli"";</p>
                                <h3 class=""text-xl sm:text-2xl font-semibold mt-2"">C# Code</h3>
                            </div>
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""48"" height=""48"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""text-gray-500 rotate-90 sm:rotate-0""><path d=""M18 10h-2.5a2.5 2.5 0 0 0-5 0H8""/><path d=""M6 14h2.5a2.5 2.5 0 0 0 5 0H16""/><path d=""M12 2v2""/><path d=""M12 20v2""/><path d=""m4.93 4.93 1.41 1.41""/><path d=""m17.66 17.66 1.41 1.41""/><path d=""m2 12 2 0""/><path d=""M20 12h2""/><path d=""m4.93 19.07 1.41-1.41""/><path d=""m17.66 6.34 1.41-1.41""/></svg>
                            <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200 text-center"">
                                <p class=""text-base sm:text-lg font-mono text-green-700"">&lt;input value=""Ulli"" /&gt;</p>
                                <h3 class=""text-xl sm:text-2xl font-semibold mt-2"">HTML UI</h3>
                            </div>
                        </div>
                    ",
                    Notes = @"
                        <p>Our final topic is Data Binding. This is a key feature of all modern UI frameworks. It's the mechanism that automatically connects your UI to your data.</p>
                        <p>Without data binding, a developer would have to write extra code to read a value from a variable and show it in a textbox, and then more code to update the variable when the user types. Data binding does this automatically.</p>
                    "
                },
                new SlideData
                {
                    Title = "How Data Binding Works",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8 md:mb-12"">How Data Binding Works</h2>
                        <div class=""grid grid-cols-1 md:grid-cols-2 gap-4 md:gap-8 w-full max-w-5xl"">
                            <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border border-gray-200"">
                                <h3 class=""text-xl sm:text-2xl font-semibold mb-4"">One-Way Connection</h3>
                                <p class=""text-base md:text-lg mb-4"">Data flows from Code → UI</p>
                                <code class=""bg-gray-100 text-gray-800 p-2 rounded text-sm sm:text-lg"">&lt;p&gt;Hello, @UserName&lt;/p&gt;</code>
                                <p class=""mt-4 text-sm sm:text-base"">Used for showing data.</p>
                            </div>
                            <div class=""bg-white p-6 md:p-8 rounded-lg shadow-lg border-2 border-blue-500"">
                                <h3 class=""text-xl sm:text-2xl font-semibold mb-4"">Two-Way Connection</h3>
                                <p class=""text-base md:text-lg mb-4"">Data flows both ways: Code ↔ UI</p>
                                <code class=""bg-gray-100 text-gray-800 p-2 rounded text-sm sm:text-lg"">&lt;input @bind=""UserName"" /&gt;</code>
                                <p class=""mt-4 text-sm sm:text-base"">Used for user input forms.</p>
                            </div>
                        </div>
                    ",
                    Notes = @"
                        <p>Blazor has two main types of data binding. <strong>One-way connection</strong> is simple: data flows from your C# code to the UI. When your code changes a variable, the UI updates. This is used for showing information.</p>
                        <p><strong>Two-way connection</strong>, using the <code>@bind</code> command, is more powerful. When the code changes the variable, the input field updates. When the user types in the input field, the C# variable updates. This makes building forms much easier and means writing less repetitive code.</p>
                    "
                },
                new SlideData
                {
                    Title = "How <code>@bind</code> Works Inside",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8"">How <code>@bind</code> Works Inside</h2>
                        <p class=""text-lg sm:text-xl md:text-2xl text-gray-600 mb-8 md:mb-12"">It's a shortcut for developers.</p>
                        <div class=""w-full max-w-4xl"">
                            <div class=""bg-gray-800 text-white font-mono p-4 sm:p-6 rounded-lg text-left text-sm sm:text-lg"">
                                <p class=""text-gray-400"">// You write this:</p>
                                <p>&lt;input <span class=""text-cyan-400"">@bind</span>=""<span class=""text-yellow-300"">UserName</span>"" /&gt;</p>
                                <br/>
                                <p class=""text-gray-400"">// The compiler generates this:</p>
                                <p>&lt;input <span class=""text-cyan-400"">value</span>=""<span class=""text-yellow-300"">@UserName</span>""</p>
                                <p class=""ml-4 sm:ml-8""><span class=""text-cyan-400"">@onchange</span>=""<span class=""text-yellow-300"">(e) => UserName = e.Value.ToString()</span>"" /&gt;</p>
                            </div>
                        </div>
                    ",
                    Notes = @"
                        <p>The <code>@bind</code> command is a helpful shortcut. It's an easy way to write something that is actually more complex.</p>
                        <p>When you write <code>@bind</code>, the Blazor compiler automatically creates the two pieces of code needed: one to set the value, and another to update the value when the user changes it.</p>
                        <p>Understanding this shows that <code>@bind</code> is not magic. It's a smart way to hide complex details and helps developers focus on the important logic, not the simple UI tasks.</p>
                    "
                },
                new SlideData
                {
                    Title = "Summary",
                    Content = @"
                        <h2 class=""text-3xl sm:text-4xl md:text-5xl font-bold mb-8 md:mb-12"">Summary</h2>
                        <div class=""text-left text-lg sm:text-xl md:text-2xl space-y-4 md:space-y-6 max-w-4xl"">
                            <p class=""flex items-start""><span class=""text-blue-600 mr-4 mt-1"">✓</span> <strong>Blazor</strong> lets you build web apps with C# and has flexible ways to run them (Server &amp; WASM).</p>
                            <p class=""flex items-start""><span class=""text-blue-600 mr-4 mt-1"">✓</span> It's a <strong>smart choice for .NET teams</strong>, making work faster by using one set of technologies.</p>
                            <p class=""flex items-start""><span class=""text-blue-600 mr-4 mt-1"">✓</span> <strong>Middleware</strong> is a key part of ASP.NET Core that handles requests for security and performance.</p>
                            <p class=""flex items-start""><span class=""text-blue-600 mr-4 mt-1"">✓</span> <strong>Data Binding</strong> automatically keeps the UI updated, which makes development simpler.</p>
                        </div>
                    ",
                    Notes = @"
                        <p>To summarize: Blazor is a great framework for building modern web apps with C#. It offers flexible choices to fit different needs.</p>
                        <p>Its main advantage is for teams already using .NET, where it makes work faster.</p>
                        <p>We also saw that core ideas like Middleware are important for building secure apps, and features like Data Binding make creating user interfaces much simpler.</p>
                    "
                },
                new SlideData
                {
                    Title = "Questions?",
                    Content = @"
                        <h1 class=""text-4xl sm:text-6xl md:text-7xl font-bold text-blue-700"">Questions?</h1>
                    ",
                    Notes = @"
                        <p>That's the end of the presentation. Thank you for your time. I'd be happy to answer any questions.</p>
                    "
                }
            };
        }
    }
}
