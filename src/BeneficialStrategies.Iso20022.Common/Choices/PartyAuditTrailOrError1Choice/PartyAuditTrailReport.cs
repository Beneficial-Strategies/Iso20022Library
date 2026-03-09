// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.PartyAuditTrailOrError1Choice
{
    /// <summary>
    /// Report information about party reference data.
    /// </summary>
    [IsoId("_QqH6IZ9uEee7Qpz45yWJJw")]
    [DisplayName("Party Audit Trail Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PartyAuditTrailReport : PartyAuditTrailOrError1Choice_
    #else
    public partial class PartyAuditTrailReport : PartyAuditTrailOrError1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PartyAuditTrailReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PartyAuditTrailReport( PartyAuditTrailOrError2Choice_ reqPartyAuditTrailOrError,SystemPartyIdentification8 reqPartyIdentification )
        {
            PartyAuditTrailOrError = reqPartyAuditTrailOrError;
            PartyIdentification = reqPartyIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the returned party reference data or error information.
        /// </summary>
        [IsoId("_Qy5boZ9uEee7Qpz45yWJJw")]
        [DisplayName("Party Audit Trail Or Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PtyAudtTrlOrErr")]
        #endif
        [IsoXmlTag("PtyAudtTrlOrErr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyAuditTrailOrError2Choice_ PartyAuditTrailOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyAuditTrailOrError2Choice_ PartyAuditTrailOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyAuditTrailOrError2Choice_ PartyAuditTrailOrError { get; init; } 
        #else
        public PartyAuditTrailOrError2Choice_ PartyAuditTrailOrError { get; set; } 
        #endif
        
        /// <summary>
        /// Period in dates for which the audit trail is provided.
        /// </summary>
        [IsoId("_Qy5bo59uEee7Qpz45yWJJw")]
        [DisplayName("Date Period")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtPrd")]
        #endif
        [IsoXmlTag("DtPrd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DatePeriod3Choice_? DatePeriod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DatePeriod3Choice_? DatePeriod { get; init; } 
        #else
        public DatePeriod3Choice_? DatePeriod { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the party for which the audit trail is provided.
        /// </summary>
        [IsoId("_Qy5bpZ9uEee7Qpz45yWJJw")]
        [DisplayName("Party Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PtyId")]
        #endif
        [IsoXmlTag("PtyId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SystemPartyIdentification8 PartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SystemPartyIdentification8 PartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyIdentification8 PartyIdentification { get; init; } 
        #else
        public SystemPartyIdentification8 PartyIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
