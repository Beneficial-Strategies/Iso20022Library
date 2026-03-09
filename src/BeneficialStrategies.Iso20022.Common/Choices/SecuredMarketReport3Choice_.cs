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
    [KnownType(typeof(SecuredMarketReport3Choice.DataSetAction))]
    [KnownType(typeof(SecuredMarketReport3Choice.Transaction))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SecuredMarketReport3Choice.DataSetAction),nameof(SecuredMarketReport3Choice.DataSetAction))]
    [JsonDerivedType(typeof(SecuredMarketReport3Choice.Transaction),nameof(SecuredMarketReport3Choice.Transaction))]
    #endif
    [IsoId("_ghnREaidEeWHO_l3hf2rlA")]
    [DisplayName("Secured Market Report 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SecuredMarketReport3Choice_
    #else
    public abstract partial class SecuredMarketReport3Choice_
    #endif
    {
    }
}
