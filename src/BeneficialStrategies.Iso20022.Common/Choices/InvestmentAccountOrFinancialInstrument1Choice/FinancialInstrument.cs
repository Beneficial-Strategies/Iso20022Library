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
namespace BeneficialStrategies.Iso20022.Choices.InvestmentAccountOrFinancialInstrument1Choice
{
    /// <summary>
    /// Instrument that has intrinsic monetary value, and may transfer value, the price of which may be obtained from a financial market, eg, a bond or a cheque.
    /// </summary>
    [IsoId("_UuOntdp-Ed-ak6NoX_4Aeg_-1126591079")]
    [DisplayName("Financial Instrument")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record FinancialInstrument : InvestmentAccountOrFinancialInstrument1Choice_
    #else
    public partial class FinancialInstrument : InvestmentAccountOrFinancialInstrument1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a FinancialInstrument instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public FinancialInstrument( SecurityIdentification1Choice_ reqIdentification )
        {
            Identification = reqIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of a security by an ISIN.
        /// </summary>
        [IsoId("_VHQyw9p-Ed-ak6NoX_4Aeg_935715975")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SecurityIdentification1Choice_ Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SecurityIdentification1Choice_ Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityIdentification1Choice_ Identification { get; init; } 
        #else
        public SecurityIdentification1Choice_ Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the financial instrument in free format text.
        /// </summary>
        [IsoId("_VHQyxNp-Ed-ak6NoX_4Aeg_935716215")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about a financial instrument to help identify the instrument.
        /// </summary>
        [IsoId("_VHQyxdp-Ed-ak6NoX_4Aeg_935716232")]
        [DisplayName("Supplementary Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SplmtryId")]
        #endif
        [IsoXmlTag("SplmtryId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SupplementaryIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SupplementaryIdentification { get; init; } 
        #else
        public System.String? SupplementaryIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, &apos;Class A&apos;, &apos;Class 2&apos;.
        /// </summary>
        [IsoId("_VHQyxtp-Ed-ak6NoX_4Aeg_935716285")]
        [DisplayName("Class Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClssTp")]
        #endif
        [IsoXmlTag("ClssTp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ClassType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ClassType { get; init; } 
        #else
        public System.String? ClassType { get; set; } 
        #endif
        
        /// <summary>
        /// Form, ie, ownership, of the security, eg, registered or bearer.
        /// </summary>
        [IsoId("_VHQyx9p-Ed-ak6NoX_4Aeg_935716267")]
        [DisplayName("Securities Form")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SctiesForm")]
        #endif
        [IsoXmlTag("SctiesForm")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FormOfSecurity1Code? SecuritiesForm { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FormOfSecurity1Code? SecuritiesForm { get; init; } 
        #else
        public FormOfSecurity1Code? SecuritiesForm { get; set; } 
        #endif
        
        /// <summary>
        /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
        /// </summary>
        [IsoId("_VHQyyNp-Ed-ak6NoX_4Aeg_935716311")]
        [DisplayName("Distribution Policy")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DstrbtnPlcy")]
        #endif
        [IsoXmlTag("DstrbtnPlcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DistributionPolicy1Code? DistributionPolicy { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DistributionPolicy1Code? DistributionPolicy { get; init; } 
        #else
        public DistributionPolicy1Code? DistributionPolicy { get; set; } 
        #endif
        
        /// <summary>
        /// Company specific description of a group of funds.
        /// </summary>
        [IsoId("_VHQyydp-Ed-ak6NoX_4Aeg_1843918691")]
        [DisplayName("Product Group")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PdctGrp")]
        #endif
        [IsoXmlTag("PdctGrp")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? ProductGroup { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ProductGroup { get; init; } 
        #else
        public System.String? ProductGroup { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
