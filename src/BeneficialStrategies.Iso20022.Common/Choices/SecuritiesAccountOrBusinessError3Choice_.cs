// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the securities account reference data or a business error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountOrBusinessError3Choice.SecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountOrBusinessError3Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesAccountOrBusinessError3Choice.SecuritiesAccount),nameof(SecuritiesAccountOrBusinessError3Choice.SecuritiesAccount))]
    [JsonDerivedType(typeof(SecuritiesAccountOrBusinessError3Choice.BusinessError),nameof(SecuritiesAccountOrBusinessError3Choice.BusinessError))]
    #endif
    [IsoId("_yC-g5Tp1Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Or Business Error 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesAccountOrBusinessError3Choice_
    #else
    public abstract partial class SecuritiesAccountOrBusinessError3Choice_
    #endif
    {
    }
}
