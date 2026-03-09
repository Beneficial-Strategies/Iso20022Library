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
    /// Choice of format for the unaffirmed reason.
    /// </summary>
    [KnownType(typeof(UnaffirmedReason2Choice.Code))]
    [KnownType(typeof(UnaffirmedReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnaffirmedReason2Choice.Code),nameof(UnaffirmedReason2Choice.Code))]
    [JsonDerivedType(typeof(UnaffirmedReason2Choice.Proprietary),nameof(UnaffirmedReason2Choice.Proprietary))]
    #endif
    [IsoId("_AzfH4NokEeC60axPepSq7g_1484054937")]
    [DisplayName("Unaffirmed Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnaffirmedReason2Choice_
    #else
    public abstract partial class UnaffirmedReason2Choice_
    #endif
    {
    }
}
