(global["webpackJsonp"]=global["webpackJsonp"]||[]).push([["pages/goods_search/index"],{"0fba":function(t,e,i){},1257:function(t,e,i){"use strict";i.r(e);var n=i("946d"),o=i.n(n);for(var a in n)"default"!==a&&function(t){i.d(e,t,(function(){return n[t]}))}(a);e["default"]=o.a},"17de":function(t,e,i){"use strict";(function(t){i("6e38");n(i("66fd"));var e=n(i("5665"));function n(t){return t&&t.__esModule?t:{default:t}}wx.__webpack_require_UNI_MP_PLUGIN__=i,t(e.default)}).call(this,i("543d")["createPage"])},"50a8":function(t,e,i){"use strict";var n;i.d(e,"b",(function(){return o})),i.d(e,"c",(function(){return a})),i.d(e,"a",(function(){return n}));var o=function(){var t=this,e=t.$createElement;t._self._c},a=[]},5665:function(t,e,i){"use strict";i.r(e);var n=i("50a8"),o=i("1257");for(var a in o)"default"!==a&&function(t){i.d(e,t,(function(){return o[t]}))}(a);i("dd63");var s,c=i("f0c5"),r=Object(c["a"])(o["default"],n["b"],n["c"],!1,null,null,null,!1,n["a"],s);e["default"]=r.exports},"946d":function(t,e,i){"use strict";(function(t){Object.defineProperty(e,"__esModule",{value:!0}),e.default=void 0;var n=i("f15c"),o=i("7fe6"),a=s(i("c83f"));function s(t){return t&&t.__esModule?t:{default:t}}var c=function(){Promise.all([i.e("common/vendor"),i.e("components/goodList/index")]).then(function(){return resolve(i("0aa1"))}.bind(null,i)).catch(i.oe)},r=function(){Promise.all([i.e("common/vendor"),i.e("components/recommend/index")]).then(function(){return resolve(i("22f5"))}.bind(null,i)).catch(i.oe)},u={components:{goodList:c,recommend:r},mixins:[a.default],data:function(){return{hostProduct:[],searchValue:"",focus:!0,bastList:[],hotSearchList:[],first:0,limit:8,page:1,loading:!1,loadend:!1,loadTitle:"加载更多",hotPage:1,isScroll:!0,history:[]}},onShow:function(){this.getHostProduct(),this.searchList();try{this.hotSearchList=t.getStorageSync("hotList")}catch(e){}},onReachBottom:function(){this.bastList.length>0?this.getProductList():this.getHostProduct()},methods:{searchList:function(){var t=this;(0,o.searchList)({page:1,limit:10}).then((function(e){t.history=e.data}))},clear:function(){var e=this;(0,o.clearSearch)().then((function(i){t.showToast({title:i.msg,success:function(){e.history=[]}})}))},inputConfirm:function(e){e.detail.value&&(t.hideKeyboard(),this.setHotSearchValue(e.detail.value))},getRoutineHotSearch:function(){var t=this;(0,n.getSearchKeyword)().then((function(e){t.$set(t,"hotSearchList",e.data)}))},getProductList:function(){var t=this;t.loadend||t.loading||(t.loading=!0,t.loadTitle="",(0,n.getProductslist)({keyword:t.searchValue.trim(),page:t.page,limit:t.limit}).then((function(e){var i=e.data,n=i.length<t.limit;t.bastList=t.$util.SplitArray(i,t.bastList),t.$set(t,"bastList",t.bastList),t.loading=!1,t.loadend=n,t.loadTitle=n?"人家是有底线的~":"加载更多",t.page=t.page+1})).catch((function(e){t.loading=!1,t.loadTitle="加载更多"})))},getHostProduct:function(){var t=this;this.isScroll&&(0,n.getProductHot)(t.hotPage,t.limit).then((function(e){t.isScroll=e.data.length>=t.limit,t.hostProduct=t.hostProduct.concat(e.data),t.hotPage+=1}))},setHotSearchValue:function(t){this.$set(this,"searchValue",t),this.page=1,this.loadend=!1,this.$set(this,"bastList",[]),this.getProductList()},setValue:function(t){this.$set(this,"searchValue",t.detail.value)},searchBut:function(){var e=this;if(!e.searchValue.trim())return this.$util.Tips({title:"请输入要搜索的商品"});e.focus=!1,e.page=1,e.loadend=!1,e.$set(e,"bastList",[]),t.showLoading({title:"正在搜索中"}),e.getProductList(),t.hideLoading()}}};e.default=u}).call(this,i("543d")["default"])},dd63:function(t,e,i){"use strict";var n=i("0fba"),o=i.n(n);o.a}},[["17de","common/runtime","common/vendor"]]]);