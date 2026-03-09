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
    /// Choice between a reason for no activity and the secured market segment transaction details.
    /// </summary>
    [KnownType(typeof(SecuredMarketReport4Choice.DataSetAction))]
    [KnownType(typeof(SecuredMarketReport4Choice.Transaction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuredMarketReport4Choice.DataSetAction),nameof(SecuredMarketReport4Choice.DataSetAction))]
    [JsonDerivedType(typeof(SecuredMarketReport4Choice.Transaction),nameof(SecuredMarketReport4Choice.Transaction))]
    #endif
    [IsoId("_GQHsIcEREea7jLfvGi1PDw")]
    [DisplayName("Secured Market Report 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuredMarketReport4Choice_
    #else
    public abstract partial class SecuredMarketReport4Choice_
    #endif
    {
    }
}
