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
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountAuditTrailOrOperationalError3Choice
{
    /// <summary>
    /// Report information about securities account reference data.
    /// </summary>
    [IsoId("_A6gAsTp0Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Audit Trail Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesAccountAuditTrailReport : SecuritiesAccountAuditTrailOrOperationalError3Choice_
    #else
    public partial class SecuritiesAccountAuditTrailReport : SecuritiesAccountAuditTrailOrOperationalError3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SecuritiesAccountAuditTrailReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SecuritiesAccountAuditTrailReport( AuditTrailOrBusinessError6Choice_ reqSecuritiesAccountAuditTrailOrError,SecuritiesAccount19 reqSecuritiesAccountIdentification )
        {
            SecuritiesAccountAuditTrailOrError = reqSecuritiesAccountAuditTrailOrError;
            SecuritiesAccountIdentification = reqSecuritiesAccountIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the returned securities account reference data or error information.
        /// </summary>
        [IsoId("_BEo0ITp0Eemk2e6qGBk8IQ")]
        [DisplayName("Securities Account Audit Trail Or Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SctiesAcctAudtTrlOrErr")]
        #endif
        [IsoXmlTag("SctiesAcctAudtTrlOrErr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required AuditTrailOrBusinessError6Choice_ SecuritiesAccountAuditTrailOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required AuditTrailOrBusinessError6Choice_ SecuritiesAccountAuditTrailOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AuditTrailOrBusinessError6Choice_ SecuritiesAccountAuditTrailOrError { get; init; } 
        #else
        public AuditTrailOrBusinessError6Choice_ SecuritiesAccountAuditTrailOrError { get; set; } 
        #endif
        
        /// <summary>
        /// Period in dates for which the audit trail is provided.
        /// </summary>
        [IsoId("_BEo0Izp0Eemk2e6qGBk8IQ")]
        [DisplayName("Date Period")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtPrd")]
        #endif
        [IsoXmlTag("DtPrd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
        #else
        public DatePeriodSearch1Choice_? DatePeriod { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the securities account for which the audit trail is provided.
        /// </summary>
        [IsoId("_BEo0JTp0Eemk2e6qGBk8IQ")]
        [DisplayName("Securities Account Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SctiesAcctId")]
        #endif
        [IsoXmlTag("SctiesAcctId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
        #else
        public SecuritiesAccount19 SecuritiesAccountIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
