(function() {
  Kooboo.loadJS([
    "/_Admin/Scripts/vue-components/htmlViewer/kbHtmlTree.js",
    "/_Admin/Scripts/vue-components/htmlViewer/kbHtmlPath.js"
  ]);
  Kooboo.loadCSS([
    "/_Admin/Scripts/vue-components/htmlViewer/kbHtmlTree.css",
    "/_Admin/Scripts/vue-components/htmlViewer/kbHtmlPath.css"
  ]);
  var self;
  Vue.component("kb-html-viewer", {
    template: Kooboo.getTemplate(
      "/_Admin/Scripts/vue-components/kbHtmlViewer.html"
    ),
    data: function() {
      self = this;
      return {
        elem: undefined,
        rootElem: undefined
      };
    },
    mounted: function() {
      Kooboo.EventBus.subscribe("kb/html/previewer/select", function(elem) {
        self.elem = elem;
      });
      Kooboo.EventBus.subscribe("kb/html/previewer/hover", function(elem) {
        Kooboo.EventBus.publish("kb/html/tree/elem/hover", elem);
      });
      Kooboo.EventBus.subscribe("kb/html/previewer/rootElem", function(elem) {
        self.rootElem = elem;
      });
    }
  });
})();
