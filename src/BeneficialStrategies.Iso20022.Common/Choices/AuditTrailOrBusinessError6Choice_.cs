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
    /// Choice between the audit trail static data or a business error.
    /// </summary>
    [KnownType(typeof(AuditTrailOrBusinessError6Choice.AuditTrail))]
    [KnownType(typeof(AuditTrailOrBusinessError6Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AuditTrailOrBusinessError6Choice.AuditTrail),nameof(AuditTrailOrBusinessError6Choice.AuditTrail))]
    [JsonDerivedType(typeof(AuditTrailOrBusinessError6Choice.BusinessError),nameof(AuditTrailOrBusinessError6Choice.BusinessError))]
    #endif
    [IsoId("_bRP60Wc-EemvNLufWGIVOQ")]
    [DisplayName("Audit Trail Or Business Error 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AuditTrailOrBusinessError6Choice_
    #else
    public abstract partial class AuditTrailOrBusinessError6Choice_
    #endif
    {
    }
}
