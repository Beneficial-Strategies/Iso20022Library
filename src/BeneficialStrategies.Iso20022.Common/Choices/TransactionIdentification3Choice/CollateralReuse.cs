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
namespace BeneficialStrategies.Iso20022.Choices.TransactionIdentification3Choice
{
    /// <summary>
    /// Identifies the collateral reuse.
    /// </summary>
    [IsoId("_hY22BcK4EeuFNp8LZAnorg")]
    [DisplayName("Collateral Reuse")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CollateralReuse : TransactionIdentification3Choice_
    #else
    public partial class CollateralReuse : TransactionIdentification3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CollateralReuse instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CollateralReuse( OrganisationIdentification15Choice_ reqReportingCounterparty,OrganisationIdentification15Choice_ reqReportSubmittingEntity )
        {
            ReportingCounterparty = reqReportingCounterparty;
            ReportSubmittingEntity = reqReportSubmittingEntity;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_IjNagM3OEeuiU4QSC_BouQ")]
        [DisplayName("Technical Record Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechRcrdId")]
        #endif
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TechnicalRecordIdentification { get; init; } 
        #else
        public System.String? TechnicalRecordIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique code identifying the reporting counterparty.
        /// </summary>
        [IsoId("_u-3_wcK4EeuFNp8LZAnorg")]
        [DisplayName("Reporting Counterparty")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptgCtrPty")]
        #endif
        [IsoXmlTag("RptgCtrPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification15Choice_ ReportingCounterparty { get; init; } 
        #else
        public OrganisationIdentification15Choice_ ReportingCounterparty { get; set; } 
        #endif
        
        /// <summary>
        /// Unique code identifying the entity which submits the report. In the case where submission of the report has been delegated to a third party or to the other counterparty, a unique code identifying that entity.
        /// </summary>
        [IsoId("_u-3_w8K4EeuFNp8LZAnorg")]
        [DisplayName("Report Submitting Entity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptSubmitgNtty")]
        #endif
        [IsoXmlTag("RptSubmitgNtty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OrganisationIdentification15Choice_ ReportSubmittingEntity { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OrganisationIdentification15Choice_ ReportSubmittingEntity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification15Choice_ ReportSubmittingEntity { get; init; } 
        #else
        public OrganisationIdentification15Choice_ ReportSubmittingEntity { get; set; } 
        #endif
        
        /// <summary>
        /// Unique code identifying that the Financial counterparty responsible for reporting on behalf of the other counterparty.
        /// </summary>
        [IsoId("_zY_aoMK4EeuFNp8LZAnorg")]
        [DisplayName("Entity Responsible For Report")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NttyRspnsblForRpt")]
        #endif
        [IsoXmlTag("NttyRspnsblForRpt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; init; } 
        #else
        public OrganisationIdentification15Choice_? EntityResponsibleForReport { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
