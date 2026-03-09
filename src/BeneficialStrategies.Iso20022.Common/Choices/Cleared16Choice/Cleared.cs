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
namespace BeneficialStrategies.Iso20022.Choices.Cleared16Choice
{
    /// <summary>
    /// Indicates that the contract has been cleared.
    /// </summary>
    [IsoId("_gKmIUcg4Eeu4ecZgAYuz5w")]
    [DisplayName("Cleared")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Cleared : Cleared16Choice_
    #else
    public partial class Cleared : Cleared16Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// In the case of a contract that has been cleared, the unique code for the clearing counterparty that has cleared the contract.
        /// </summary>
        [IsoId("_gMBrs8g4Eeu4ecZgAYuz5w")]
        [DisplayName("CCP")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CCP")]
        #endif
        [IsoXmlTag("CCP")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OrganisationIdentification15Choice_? CCP { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationIdentification15Choice_? CCP { get; init; } 
        #else
        public OrganisationIdentification15Choice_? CCP { get; set; } 
        #endif
        
        /// <summary>
        /// Time and date when clearing took place.
        /// </summary>
        [IsoId("_gMBrtcg4Eeu4ecZgAYuz5w")]
        [DisplayName("Clearing Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrDtTm")]
        #endif
        [IsoXmlTag("ClrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? ClearingDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? ClearingDateTime { get; init; } 
        #else
        public System.DateTime? ClearingDateTime { get; set; } 
        #endif
        
        /// <summary>
        /// Unique number to indicate a group of reports which relate to the same execution.
        /// </summary>
        [IsoId("_gMBrt8g4Eeu4ecZgAYuz5w")]
        [DisplayName("Report Tracking Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptTrckgNb")]
        #endif
        [IsoXmlTag("RptTrckgNb")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax52Text? ReportTrackingNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ReportTrackingNumber { get; init; } 
        #else
        public System.String? ReportTrackingNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Unique code determined by the reporting counterparty identifying the portfolio.
        /// </summary>
        [IsoId("_gMBrucg4Eeu4ecZgAYuz5w")]
        [DisplayName("Portfolio Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrtflCd")]
        #endif
        [IsoXmlTag("PrtflCd")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax52Text? PortfolioCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PortfolioCode { get; init; } 
        #else
        public System.String? PortfolioCode { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
