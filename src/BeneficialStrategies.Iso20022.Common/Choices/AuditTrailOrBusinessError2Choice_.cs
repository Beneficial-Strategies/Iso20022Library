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
    /// Report between the static data audit trail or a business error.
    /// </summary>
    [KnownType(typeof(AuditTrailOrBusinessError2Choice.AuditTrail))]
    [KnownType(typeof(AuditTrailOrBusinessError2Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AuditTrailOrBusinessError2Choice.AuditTrail),nameof(AuditTrailOrBusinessError2Choice.AuditTrail))]
    [JsonDerivedType(typeof(AuditTrailOrBusinessError2Choice.BusinessError),nameof(AuditTrailOrBusinessError2Choice.BusinessError))]
    #endif
    [IsoId("_BaOI8fAzEeWPfa2xBhBfLQ")]
    [DisplayName("Audit Trail Or Business Error 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AuditTrailOrBusinessError2Choice_
    #else
    public abstract partial class AuditTrailOrBusinessError2Choice_
    #endif
    {
    }
}
