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
namespace BeneficialStrategies.Iso20022.Choices.SecuredCollateral1Choice
{
    /// <summary>
    /// Identifies the collateral when the asset class pledged as collateral does not correspond to an ISIN.
    /// </summary>
    [IsoId("_aPU1wZgAEeSfnc-VXAEapg")]
    [DisplayName("Other Collateral")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OtherCollateral : SecuredCollateral1Choice_
    #else
    public partial class OtherCollateral : SecuredCollateral1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OtherCollateral instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OtherCollateral( CollateralPool1Code reqPoolStatus,System.String reqType,System.String reqSector )
        {
            PoolStatus = reqPoolStatus;
            Type = reqType;
            Sector = reqSector;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies whether the collateral is a pool collateral or not.
        /// </summary>
        [IsoId("_gfxkUN7GEeSaBeqd_btViQ")]
        [DisplayName("Pool Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PoolSts")]
        #endif
        [IsoXmlTag("PoolSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CollateralPool1Code PoolStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CollateralPool1Code PoolStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralPool1Code PoolStatus { get; init; } 
        #else
        public CollateralPool1Code PoolStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the asset class pledged as collateral, expressed as an ISO 10962 Classification of Financial Instrument (CFI).
        /// </summary>
        [IsoId("_5UkowZf7EeSfnc-VXAEapg")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        [IsoSimpleType(IsoSimpleType.CFIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoCFIIdentifier Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Type { get; init; } 
        #else
        public System.String Type { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the institutional sector, such as central government, central bank, etc. of the issuer of collateral.
        /// </summary>
        [IsoId("_0ZPaYZf_EeSfnc-VXAEapg")]
        [DisplayName("Sector")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sctr")]
        #endif
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.SNA2008SectorIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoSNA2008SectorIdentifier Sector { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Sector { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Sector { get; init; } 
        #else
        public System.String Sector { get; set; } 
        #endif
        
        /// <summary>
        /// Nominal amount of money of the security pledged as collateral, when the collateral cannot be identified through an individual or basket ISIN.
        /// </summary>
        [IsoId("_DWHbp5f7EeSfnc-VXAEapg")]
        [DisplayName("Nominal Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NmnlAmt")]
        #endif
        [IsoXmlTag("NmnlAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveCurrencyAndAmount? NominalAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveCurrencyAndAmount? NominalAmount { get; init; } 
        #else
        public ActiveCurrencyAndAmount? NominalAmount { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
