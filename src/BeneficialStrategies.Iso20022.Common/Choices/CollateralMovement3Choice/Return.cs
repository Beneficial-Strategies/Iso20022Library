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
namespace BeneficialStrategies.Iso20022.Choices.CollateralMovement3Choice
{
    /// <summary>
    /// Provides the collateral movement direction that is a return only.
    /// </summary>
    [IsoId("_QtN1s19-EeSMgPeFpRHeJw")]
    [DisplayName("Return")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Return : CollateralMovement3Choice_
    #else
    public partial class Return : CollateralMovement3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Return instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Return( System.String reqMarginCallRequestIdentification )
        {
            MarginCallRequestIdentification = reqMarginCallRequestIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the reference to the unambiguous identification of the margin call request.
        /// </summary>
        [IsoId("_dL_DgV9-EeSMgPeFpRHeJw")]
        [DisplayName("Margin Call Request Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MrgnCallReqId")]
        #endif
        [IsoXmlTag("MrgnCallReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text MarginCallRequestIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String MarginCallRequestIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String MarginCallRequestIdentification { get; init; } 
        #else
        public System.String MarginCallRequestIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the reference to the unambiguous identification of the margin call response.
        /// </summary>
        [IsoId("_dL_Dg19-EeSMgPeFpRHeJw")]
        [DisplayName("Margin Call Response Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MrgnCallRspnId")]
        #endif
        [IsoXmlTag("MrgnCallRspnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MarginCallResponseIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MarginCallResponseIdentification { get; init; } 
        #else
        public System.String? MarginCallResponseIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the standard settlement instructions.
        /// </summary>
        [IsoId("_dL_DhV9-EeSMgPeFpRHeJw")]
        [DisplayName("Standard Settlement Instructions")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StdSttlmInstrs")]
        #endif
        [IsoXmlTag("StdSttlmInstrs")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? StandardSettlementInstructions { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? StandardSettlementInstructions { get; init; } 
        #else
        public System.String? StandardSettlementInstructions { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the reference to the unambiguous identification of the collateral proposal response (in case of counter proposal).
        /// </summary>
        [IsoId("_dL_Dh19-EeSMgPeFpRHeJw")]
        [DisplayName("Collateral Proposal Response Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollPrpslRspnId")]
        #endif
        [IsoXmlTag("CollPrpslRspnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? CollateralProposalResponseIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CollateralProposalResponseIdentification { get; init; } 
        #else
        public System.String? CollateralProposalResponseIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Collateral type is securities.
        /// </summary>
        [IsoId("_dL_DiV9-EeSMgPeFpRHeJw")]
        [DisplayName("Securities Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SctiesColl")]
        #endif
        [IsoXmlTag("SctiesColl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesCollateral3? SecuritiesCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesCollateral3? SecuritiesCollateral { get; init; } 
        #else
        public SecuritiesCollateral3? SecuritiesCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// Collateral type is cash.
        /// </summary>
        [IsoId("_dL_Di19-EeSMgPeFpRHeJw")]
        [DisplayName("Cash Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CshColl")]
        #endif
        [IsoXmlTag("CshColl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashCollateral2? CashCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashCollateral2? CashCollateral { get; init; } 
        #else
        public CashCollateral2? CashCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// Collateral type is other than securities or cash for example letter of credit.
        /// </summary>
        [IsoId("_dL_DjV9-EeSMgPeFpRHeJw")]
        [DisplayName("Other Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OthrColl")]
        #endif
        [IsoXmlTag("OthrColl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OtherCollateral2? OtherCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OtherCollateral2? OtherCollateral { get; init; } 
        #else
        public OtherCollateral2? OtherCollateral { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
