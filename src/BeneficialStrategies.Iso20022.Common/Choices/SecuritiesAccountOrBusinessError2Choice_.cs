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
    /// Set of elements used to report between the securities account reference data or a business error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountOrBusinessError2Choice.SecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountOrBusinessError2Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuritiesAccountOrBusinessError2Choice.SecuritiesAccount),nameof(SecuritiesAccountOrBusinessError2Choice.SecuritiesAccount))]
    [JsonDerivedType(typeof(SecuritiesAccountOrBusinessError2Choice.BusinessError),nameof(SecuritiesAccountOrBusinessError2Choice.BusinessError))]
    #endif
    [IsoId("_ABHykfA0EeWPfa2xBhBfLQ")]
    [DisplayName("Securities Account Or Business Error 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuritiesAccountOrBusinessError2Choice_
    #else
    public abstract partial class SecuritiesAccountOrBusinessError2Choice_
    #endif
    {
    }
}
