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
    /// Choice of format for the allegment reason.
    /// </summary>
    [KnownType(typeof(AllegementReason2Choice.Code))]
    [KnownType(typeof(AllegementReason2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AllegementReason2Choice.Code),nameof(AllegementReason2Choice.Code))]
    [JsonDerivedType(typeof(AllegementReason2Choice.Proprietary),nameof(AllegementReason2Choice.Proprietary))]
    #endif
    [IsoId("_3TyQtQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Allegement Reason 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AllegementReason2Choice_
    #else
    public abstract partial class AllegementReason2Choice_
    #endif
    {
    }
}
