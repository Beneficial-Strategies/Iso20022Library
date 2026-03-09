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
    [KnownType(typeof(PartyAuditTrailOrError2Choice.AuditTrail))]
    [KnownType(typeof(PartyAuditTrailOrError2Choice.BusinessError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PartyAuditTrailOrError2Choice.AuditTrail),nameof(PartyAuditTrailOrError2Choice.AuditTrail))]
    [JsonDerivedType(typeof(PartyAuditTrailOrError2Choice.BusinessError),nameof(PartyAuditTrailOrError2Choice.BusinessError))]
    #endif
    [IsoId("_G7GHAWjHEeiCUdTMLdZoIg")]
    [DisplayName("Party Audit Trail Or Error 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PartyAuditTrailOrError2Choice_
    #else
    public abstract partial class PartyAuditTrailOrError2Choice_
    #endif
    {
    }
}
