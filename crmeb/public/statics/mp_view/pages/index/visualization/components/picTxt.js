(global["webpackJsonp"]=global["webpackJsonp"]||[]).push([["pages/index/visualization/components/picTxt"],{"059c":function(n,t,e){},5684:function(n,t,e){"use strict";Object.defineProperty(t,"__esModule",{value:!0}),t.default=void 0;e("4729");var o=getApp(),i=function(){Promise.all([e.e("common/vendor"),e.e("components/jyf-parser/jyf-parser")]).then(function(){return resolve(e("9902"))}.bind(null,e)).catch(e.oe)},r={name:"picTxt",props:{dataConfig:{type:Object,default:function(){}}},components:{"jyf-parser":i},watch:{dataConfig:{immediate:!0,handler:function(n,t){n&&(this.description=n.richText.val,this.isShow=n.isShow.val)}}},data:function(){return{description:"",name:this.$options.name,isIframe:o.globalData.isIframe,isShow:!0,tagStyle:{img:"width:100%;display:block",video:"width: 100% !important;"}}},created:function(){},mounted:function(){},methods:{}};t.default=r},7935:function(n,t,e){"use strict";e.r(t);var o=e("9cce"),i=e("b003");for(var r in i)"default"!==r&&function(n){e.d(t,n,(function(){return i[n]}))}(r);e("87c0");var a,c=e("f0c5"),u=Object(c["a"])(i["default"],o["b"],o["c"],!1,null,"92e1b6ce",null,!1,o["a"],a);t["default"]=u.exports},"87c0":function(n,t,e){"use strict";var o=e("059c"),i=e.n(o);i.a},"9cce":function(n,t,e){"use strict";e.d(t,"b",(function(){return i})),e.d(t,"c",(function(){return r})),e.d(t,"a",(function(){return o}));var o={jyfParser:function(){return Promise.all([e.e("common/vendor"),e.e("components/jyf-parser/jyf-parser")]).then(e.bind(null,"9902"))}},i=function(){var n=this,t=n.$createElement;n._self._c},r=[]},b003:function(n,t,e){"use strict";e.r(t);var o=e("5684"),i=e.n(o);for(var r in o)"default"!==r&&function(n){e.d(t,n,(function(){return o[n]}))}(r);t["default"]=i.a}}]);
;(global["webpackJsonp"] = global["webpackJsonp"] || []).push([
    'pages/index/visualization/components/picTxt-create-component',
    {
        'pages/index/visualization/components/picTxt-create-component':(function(module, exports, __webpack_require__){
            __webpack_require__('543d')['createComponent'](__webpack_require__("7935"))
        })
    },
    [['pages/index/visualization/components/picTxt-create-component']]
]);