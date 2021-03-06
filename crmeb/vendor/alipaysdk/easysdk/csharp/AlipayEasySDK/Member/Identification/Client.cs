// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using Alipay.EasySDK.Member.Identification.Models;

namespace Alipay.EasySDK.Member.Identification
{
    public class Client 
    {
        protected Alipay.EasySDK.Kernel.Client _kernel;

        public Client(Alipay.EasySDK.Kernel.Client kernel)
        {
            this._kernel = kernel;
        }

        public AlipayUserCertifyOpenInitializeResponse Init(string outerOrderNo, string bizCode, IdentityParam identityParam, MerchantConfig merchantConfig)
        {
            identityParam.Validate();
            merchantConfig.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"connectTimeout", 15000},
                {"readTimeout", 15000},
                {"retry", new Dictionary<string, int?>
                {
                    {"maxAttempts", 0},
                }},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> systemParams = new Dictionary<string, string>
                    {
                        {"method", "alipay.user.certify.open.initialize"},
                        {"app_id", this._kernel.GetConfig("appId")},
                        {"timestamp", this._kernel.GetTimestamp()},
                        {"format", "json"},
                        {"version", "1.0"},
                        {"alipay_sdk", this._kernel.GetSdkVersion()},
                        {"charset", "UTF-8"},
                        {"sign_type", this._kernel.GetConfig("signType")},
                        {"app_cert_sn", this._kernel.GetMerchantCertSN()},
                        {"alipay_root_cert_sn", this._kernel.GetAlipayRootCertSN()},
                    };
                    Dictionary<string, object> bizParams = new Dictionary<string, object>
                    {
                        {"outer_order_no", outerOrderNo},
                        {"biz_code", bizCode},
                        {"identity_param", identityParam},
                        {"merchant_config", merchantConfig},
                    };
                    Dictionary<string, string> textParams = new Dictionary<string, string>(){};
                    request_.Protocol = this._kernel.GetConfig("protocol");
                    request_.Method = "POST";
                    request_.Pathname = "/gateway.do";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", this._kernel.GetConfig("gatewayHost")},
                        {"content-type", "application/x-www-form-urlencoded;charset=utf-8"},
                    };
                    request_.Query = this._kernel.SortMap(TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"sign", this._kernel.Sign(systemParams, bizParams, textParams, this._kernel.GetConfig("merchantPrivateKey"))},
                        },
                        systemParams,
                        textParams
                    ));
                    request_.Body = TeaCore.BytesReadable(this._kernel.ToUrlEncodedRequestBody(bizParams));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = this._kernel.ReadAsJson(response_, "alipay.user.certify.open.initialize");
                    if (this._kernel.IsCertMode())
                    {
                        if (this._kernel.Verify(respMap, this._kernel.ExtractAlipayPublicKey(this._kernel.GetAlipayCertSN(respMap))))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenInitializeResponse>(this._kernel.ToRespModel(respMap));
                        }
                    }
                    else
                    {
                        if (this._kernel.Verify(respMap, this._kernel.GetConfig("alipayPublicKey")))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenInitializeResponse>(this._kernel.ToRespModel(respMap));
                        }
                    }
                    throw new TeaException(new Dictionary<string, string>
                    {
                        {"message", "????????????????????????????????????????????????????????????"},
                    });
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<AlipayUserCertifyOpenInitializeResponse> InitAsync(string outerOrderNo, string bizCode, IdentityParam identityParam, MerchantConfig merchantConfig)
        {
            identityParam.Validate();
            merchantConfig.Validate();
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"connectTimeout", 15000},
                {"readTimeout", 15000},
                {"retry", new Dictionary<string, int?>
                {
                    {"maxAttempts", 0},
                }},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> systemParams = new Dictionary<string, string>
                    {
                        {"method", "alipay.user.certify.open.initialize"},
                        {"app_id", this._kernel.GetConfig("appId")},
                        {"timestamp", this._kernel.GetTimestamp()},
                        {"format", "json"},
                        {"version", "1.0"},
                        {"alipay_sdk", this._kernel.GetSdkVersion()},
                        {"charset", "UTF-8"},
                        {"sign_type", this._kernel.GetConfig("signType")},
                        {"app_cert_sn", this._kernel.GetMerchantCertSN()},
                        {"alipay_root_cert_sn", this._kernel.GetAlipayRootCertSN()},
                    };
                    Dictionary<string, object> bizParams = new Dictionary<string, object>
                    {
                        {"outer_order_no", outerOrderNo},
                        {"biz_code", bizCode},
                        {"identity_param", identityParam},
                        {"merchant_config", merchantConfig},
                    };
                    Dictionary<string, string> textParams = new Dictionary<string, string>(){};
                    request_.Protocol = this._kernel.GetConfig("protocol");
                    request_.Method = "POST";
                    request_.Pathname = "/gateway.do";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", this._kernel.GetConfig("gatewayHost")},
                        {"content-type", "application/x-www-form-urlencoded;charset=utf-8"},
                    };
                    request_.Query = this._kernel.SortMap(TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"sign", this._kernel.Sign(systemParams, bizParams, textParams, this._kernel.GetConfig("merchantPrivateKey"))},
                        },
                        systemParams,
                        textParams
                    ));
                    request_.Body = TeaCore.BytesReadable(this._kernel.ToUrlEncodedRequestBody(bizParams));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = await this._kernel.ReadAsJsonAsync(response_, "alipay.user.certify.open.initialize");
                    if (this._kernel.IsCertMode())
                    {
                        if (this._kernel.Verify(respMap, this._kernel.ExtractAlipayPublicKey(this._kernel.GetAlipayCertSN(respMap))))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenInitializeResponse>(this._kernel.ToRespModel(respMap));
                        }
                    }
                    else
                    {
                        if (this._kernel.Verify(respMap, this._kernel.GetConfig("alipayPublicKey")))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenInitializeResponse>(this._kernel.ToRespModel(respMap));
                        }
                    }
                    throw new TeaException(new Dictionary<string, string>
                    {
                        {"message", "????????????????????????????????????????????????????????????"},
                    });
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AlipayUserCertifyOpenQueryResponse Query(string certifyId)
        {
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"connectTimeout", 15000},
                {"readTimeout", 15000},
                {"retry", new Dictionary<string, int?>
                {
                    {"maxAttempts", 0},
                }},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> systemParams = new Dictionary<string, string>
                    {
                        {"method", "alipay.user.certify.open.query"},
                        {"app_id", this._kernel.GetConfig("appId")},
                        {"timestamp", this._kernel.GetTimestamp()},
                        {"format", "json"},
                        {"version", "1.0"},
                        {"alipay_sdk", this._kernel.GetSdkVersion()},
                        {"charset", "UTF-8"},
                        {"sign_type", this._kernel.GetConfig("signType")},
                        {"app_cert_sn", this._kernel.GetMerchantCertSN()},
                        {"alipay_root_cert_sn", this._kernel.GetAlipayRootCertSN()},
                    };
                    Dictionary<string, object> bizParams = new Dictionary<string, object>
                    {
                        {"certify_id", certifyId},
                    };
                    Dictionary<string, string> textParams = new Dictionary<string, string>(){};
                    request_.Protocol = this._kernel.GetConfig("protocol");
                    request_.Method = "POST";
                    request_.Pathname = "/gateway.do";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", this._kernel.GetConfig("gatewayHost")},
                        {"content-type", "application/x-www-form-urlencoded;charset=utf-8"},
                    };
                    request_.Query = this._kernel.SortMap(TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"sign", this._kernel.Sign(systemParams, bizParams, textParams, this._kernel.GetConfig("merchantPrivateKey"))},
                        },
                        systemParams,
                        textParams
                    ));
                    request_.Body = TeaCore.BytesReadable(this._kernel.ToUrlEncodedRequestBody(bizParams));
                    _lastRequest = request_;
                    TeaResponse response_ = TeaCore.DoAction(request_, runtime_);

                    Dictionary<string, object> respMap = this._kernel.ReadAsJson(response_, "alipay.user.certify.open.query");
                    if (this._kernel.IsCertMode())
                    {
                        if (this._kernel.Verify(respMap, this._kernel.ExtractAlipayPublicKey(this._kernel.GetAlipayCertSN(respMap))))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenQueryResponse>(this._kernel.ToRespModel(respMap));
                        }
                    }
                    else
                    {
                        if (this._kernel.Verify(respMap, this._kernel.GetConfig("alipayPublicKey")))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenQueryResponse>(this._kernel.ToRespModel(respMap));
                        }
                    }
                    throw new TeaException(new Dictionary<string, string>
                    {
                        {"message", "????????????????????????????????????????????????????????????"},
                    });
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public async Task<AlipayUserCertifyOpenQueryResponse> QueryAsync(string certifyId)
        {
            Dictionary<string, object> runtime_ = new Dictionary<string, object>
            {
                {"connectTimeout", 15000},
                {"readTimeout", 15000},
                {"retry", new Dictionary<string, int?>
                {
                    {"maxAttempts", 0},
                }},
            };

            TeaRequest _lastRequest = null;
            Exception _lastException = null;
            long _now = System.DateTime.Now.Millisecond;
            int _retryTimes = 0;
            while (TeaCore.AllowRetry((IDictionary) runtime_["retry"], _retryTimes, _now))
            {
                if (_retryTimes > 0)
                {
                    int backoffTime = TeaCore.GetBackoffTime((IDictionary)runtime_["backoff"], _retryTimes);
                    if (backoffTime > 0)
                    {
                        TeaCore.Sleep(backoffTime);
                    }
                }
                _retryTimes = _retryTimes + 1;
                try
                {
                    TeaRequest request_ = new TeaRequest();
                    Dictionary<string, string> systemParams = new Dictionary<string, string>
                    {
                        {"method", "alipay.user.certify.open.query"},
                        {"app_id", this._kernel.GetConfig("appId")},
                        {"timestamp", this._kernel.GetTimestamp()},
                        {"format", "json"},
                        {"version", "1.0"},
                        {"alipay_sdk", this._kernel.GetSdkVersion()},
                        {"charset", "UTF-8"},
                        {"sign_type", this._kernel.GetConfig("signType")},
                        {"app_cert_sn", this._kernel.GetMerchantCertSN()},
                        {"alipay_root_cert_sn", this._kernel.GetAlipayRootCertSN()},
                    };
                    Dictionary<string, object> bizParams = new Dictionary<string, object>
                    {
                        {"certify_id", certifyId},
                    };
                    Dictionary<string, string> textParams = new Dictionary<string, string>(){};
                    request_.Protocol = this._kernel.GetConfig("protocol");
                    request_.Method = "POST";
                    request_.Pathname = "/gateway.do";
                    request_.Headers = new Dictionary<string, string>
                    {
                        {"host", this._kernel.GetConfig("gatewayHost")},
                        {"content-type", "application/x-www-form-urlencoded;charset=utf-8"},
                    };
                    request_.Query = this._kernel.SortMap(TeaConverter.merge<string>
                    (
                        new Dictionary<string, string>()
                        {
                            {"sign", this._kernel.Sign(systemParams, bizParams, textParams, this._kernel.GetConfig("merchantPrivateKey"))},
                        },
                        systemParams,
                        textParams
                    ));
                    request_.Body = TeaCore.BytesReadable(this._kernel.ToUrlEncodedRequestBody(bizParams));
                    _lastRequest = request_;
                    TeaResponse response_ = await TeaCore.DoActionAsync(request_, runtime_);

                    Dictionary<string, object> respMap = await this._kernel.ReadAsJsonAsync(response_, "alipay.user.certify.open.query");
                    if (this._kernel.IsCertMode())
                    {
                        if (this._kernel.Verify(respMap, this._kernel.ExtractAlipayPublicKey(this._kernel.GetAlipayCertSN(respMap))))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenQueryResponse>(this._kernel.ToRespModel(respMap));
                        }
                    }
                    else
                    {
                        if (this._kernel.Verify(respMap, this._kernel.GetConfig("alipayPublicKey")))
                        {
                            return TeaModel.ToObject<AlipayUserCertifyOpenQueryResponse>(this._kernel.ToRespModel(respMap));
                        }
                    }
                    throw new TeaException(new Dictionary<string, string>
                    {
                        {"message", "????????????????????????????????????????????????????????????"},
                    });
                }
                catch (Exception e)
                {
                    if (TeaCore.IsRetryable(e))
                    {
                        _lastException = e;
                        continue;
                    }
                    throw e;
                }
            }

            throw new TeaUnretryableException(_lastRequest, _lastException);
        }

        public AlipayUserCertifyOpenCertifyResponse Certify(string certifyId)
        {
            Dictionary<string, string> systemParams = new Dictionary<string, string>
            {
                {"method", "alipay.user.certify.open.certify"},
                {"app_id", this._kernel.GetConfig("appId")},
                {"timestamp", this._kernel.GetTimestamp()},
                {"format", "json"},
                {"version", "1.0"},
                {"alipay_sdk", this._kernel.GetSdkVersion()},
                {"charset", "UTF-8"},
                {"sign_type", this._kernel.GetConfig("signType")},
                {"app_cert_sn", this._kernel.GetMerchantCertSN()},
                {"alipay_root_cert_sn", this._kernel.GetAlipayRootCertSN()},
            };
            Dictionary<string, object> bizParams = new Dictionary<string, object>
            {
                {"certify_id", certifyId},
            };
            Dictionary<string, string> textParams = new Dictionary<string, string>(){};
            string sign = this._kernel.Sign(systemParams, bizParams, textParams, this._kernel.GetConfig("merchantPrivateKey"));
            Dictionary<string, string> response = new Dictionary<string, string>
            {
                {"body", this._kernel.GeneratePage("GET", systemParams, bizParams, textParams, sign)},
            };
            return TeaModel.ToObject<AlipayUserCertifyOpenCertifyResponse>(response);
        }

        
        /// <summary>
        /// ISV????????????????????????appAuthToken
        /// </summary>
        /// <param name="appAuthToken">?????????token</param>
        /// <returns>?????????????????????????????????</returns>
        public Client Agent(string appAuthToken)
        {
            _kernel.InjectTextParam("app_auth_token", appAuthToken);
            return this;
        }

        /// <summary>
        /// ???????????????????????????authToken
        /// </summary>
        /// <param name="authToken">????????????token</param>
        /// <returns>?????????????????????????????????</returns>
        public Client Auth(string authToken)
        {
            _kernel.InjectTextParam("auth_token", authToken);
            return this;
        }

        /// <summary>
        /// ?????????????????????????????????????????????????????????????????????Config??????????????????
        /// </summary>
        /// <param name="url">????????????????????????????????????https://www.test.com/callback </param>
        /// <returns>?????????????????????????????????</returns>
        public Client AsyncNotify(string url)
        {
            _kernel.InjectTextParam("notify_url", url);
            return this;
        }

        /// <summary>
        /// ????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????
        /// </summary>
        /// <param name="testUrl">????????????????????????</param>
        /// <returns>?????????????????????????????????</returns>
        public Client Route(string testUrl)
        {
            _kernel.InjectTextParam("ws_service_url", testUrl);
            return this;
        }

        /// <summary>
        /// ??????API????????????????????????????????????????????????(biz_content????????????)
        /// </summary>
        /// <param name="key">???????????????????????????biz_content????????????????????????timeout_express???</param>
        /// <param name="value">
        /// ???????????????????????????????????????????????????JSON?????????
        /// ??????????????????????????????????????????String???Price???Date???SDK?????????????????????????????????string??????
        /// ???????????????????????????????????????????????????Number???????????????long??????
        /// ?????????????????????????????????????????????????????????Dictionary???????????????????????????
        /// ??????????????????????????????????????????List???????????????
        /// ????????????????????????????????????Dictionary???List????????????????????????????????????????????????List???List???????????????????????????????????????
        /// </param>
        /// <returns>?????????????????????????????????</returns>
        public Client Optional(string key, object value)
        {
            _kernel.InjectBizParam(key, value);
            return this;
        }

        /// <summary>
        /// ????????????API????????????????????????????????????????????????(biz_content????????????)
        /// optional?????????????????????
        /// </summary>
        /// <param name="optionalArgs">????????????????????????????????????key???value?????????key???value??????????????????optional???????????????</param>
        /// <returns>?????????????????????????????????</returns>
        public Client BatchOptional(Dictionary<string, object> optionalArgs)
        {
            foreach (var pair in optionalArgs)
            {
                _kernel.InjectBizParam(pair.Key, pair.Value);
            }
            return this;
        }
    }
}