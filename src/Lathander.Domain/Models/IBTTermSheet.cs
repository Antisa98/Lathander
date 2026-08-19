using System;
using System.Collections.Generic;
using System.Text;

namespace Lathander.Domain.Models;

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.vontobel.com/dataservice/v1.0", IsNullable = false)]
public partial class IBTTermSheet
{

    private IBTTermSheetAdminData adminDataField;

    private IBTTermSheetEvents eventsField;

    private IBTTermSheetContact[] contactsField;

    private IBTTermSheetRegulatoryData regulatoryDataField;

    private IBTTermSheetInstrument instrumentField;

    /// <remarks/>
    public IBTTermSheetAdminData AdminData
    {
        get
        {
            return this.adminDataField;
        }
        set
        {
            this.adminDataField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetEvents Events
    {
        get
        {
            return this.eventsField;
        }
        set
        {
            this.eventsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Contact", IsNullable = false)]
    public IBTTermSheetContact[] Contacts
    {
        get
        {
            return this.contactsField;
        }
        set
        {
            this.contactsField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetRegulatoryData RegulatoryData
    {
        get
        {
            return this.regulatoryDataField;
        }
        set
        {
            this.regulatoryDataField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrument Instrument
    {
        get
        {
            return this.instrumentField;
        }
        set
        {
            this.instrumentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetAdminData
{

    private uint submitterInternalReferenceField;

    private string definitiveTermsFlagField;

    private string simulationFlagField;

    private System.DateTime effectiveFromDateField;

    private object correlationIdField;

    private string receiverField;

    private string issuerIdField;

    private string distributorIdField;

    private string trackingIdField;

    private object distributorReferenceIdField;

    private byte messageStatusField;

    private string custodianField;

    /// <remarks/>
    public uint SubmitterInternalReference
    {
        get
        {
            return this.submitterInternalReferenceField;
        }
        set
        {
            this.submitterInternalReferenceField = value;
        }
    }

    /// <remarks/>
    public string DefinitiveTermsFlag
    {
        get
        {
            return this.definitiveTermsFlagField;
        }
        set
        {
            this.definitiveTermsFlagField = value;
        }
    }

    /// <remarks/>
    public string SimulationFlag
    {
        get
        {
            return this.simulationFlagField;
        }
        set
        {
            this.simulationFlagField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime EffectiveFromDate
    {
        get
        {
            return this.effectiveFromDateField;
        }
        set
        {
            this.effectiveFromDateField = value;
        }
    }

    /// <remarks/>
    public object CorrelationId
    {
        get
        {
            return this.correlationIdField;
        }
        set
        {
            this.correlationIdField = value;
        }
    }

    /// <remarks/>
    public string Receiver
    {
        get
        {
            return this.receiverField;
        }
        set
        {
            this.receiverField = value;
        }
    }

    /// <remarks/>
    public string IssuerId
    {
        get
        {
            return this.issuerIdField;
        }
        set
        {
            this.issuerIdField = value;
        }
    }

    /// <remarks/>
    public string DistributorId
    {
        get
        {
            return this.distributorIdField;
        }
        set
        {
            this.distributorIdField = value;
        }
    }

    /// <remarks/>
    public string TrackingId
    {
        get
        {
            return this.trackingIdField;
        }
        set
        {
            this.trackingIdField = value;
        }
    }

    /// <remarks/>
    public object DistributorReferenceId
    {
        get
        {
            return this.distributorReferenceIdField;
        }
        set
        {
            this.distributorReferenceIdField = value;
        }
    }

    /// <remarks/>
    public byte MessageStatus
    {
        get
        {
            return this.messageStatusField;
        }
        set
        {
            this.messageStatusField = value;
        }
    }

    /// <remarks/>
    public string Custodian
    {
        get
        {
            return this.custodianField;
        }
        set
        {
            this.custodianField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetEvents
{

    private IBTTermSheetEventsEvent eventField;

    /// <remarks/>
    public IBTTermSheetEventsEvent Event
    {
        get
        {
            return this.eventField;
        }
        set
        {
            this.eventField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetEventsEvent
{

    private ushort eventTypeField;

    private object updateCommentField;

    /// <remarks/>
    public ushort EventType
    {
        get
        {
            return this.eventTypeField;
        }
        set
        {
            this.eventTypeField = value;
        }
    }

    /// <remarks/>
    public object UpdateComment
    {
        get
        {
            return this.updateCommentField;
        }
        set
        {
            this.updateCommentField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetContact
{

    private byte contactTypeField;

    private string contactNameField;

    private string telephoneNoField;

    private string faxNoField;

    private string emailAddressField;

    /// <remarks/>
    public byte ContactType
    {
        get
        {
            return this.contactTypeField;
        }
        set
        {
            this.contactTypeField = value;
        }
    }

    /// <remarks/>
    public string ContactName
    {
        get
        {
            return this.contactNameField;
        }
        set
        {
            this.contactNameField = value;
        }
    }

    /// <remarks/>
    public string TelephoneNo
    {
        get
        {
            return this.telephoneNoField;
        }
        set
        {
            this.telephoneNoField = value;
        }
    }

    /// <remarks/>
    public string FaxNo
    {
        get
        {
            return this.faxNoField;
        }
        set
        {
            this.faxNoField = value;
        }
    }

    /// <remarks/>
    public string EmailAddress
    {
        get
        {
            return this.emailAddressField;
        }
        set
        {
            this.emailAddressField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryData
{

    private IBTTermSheetRegulatoryDataMiFIDPRIIPData miFIDPRIIPDataField;

    private IBTTermSheetRegulatoryDataFIDLEGData fIDLEGDataField;

    /// <remarks/>
    public IBTTermSheetRegulatoryDataMiFIDPRIIPData MiFIDPRIIPData
    {
        get
        {
            return this.miFIDPRIIPDataField;
        }
        set
        {
            this.miFIDPRIIPDataField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetRegulatoryDataFIDLEGData FIDLEGData
    {
        get
        {
            return this.fIDLEGDataField;
        }
        set
        {
            this.fIDLEGDataField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryDataMiFIDPRIIPData
{

    private string leveragedInstrumentFlagField;

    private byte instrumentComplexityTypeField;

    private IBTTermSheetRegulatoryDataMiFIDPRIIPDataLossBearingCapacity lossBearingCapacityField;

    private IBTTermSheetRegulatoryDataMiFIDPRIIPDataKnowledgeExperience knowledgeExperienceField;

    private byte riskIndicatorTypeField;

    private object riskYieldProfileTypeField;

    private IBTTermSheetRegulatoryDataMiFIDPRIIPDataCustomerCategory customerCategoryField;

    private IBTTermSheetRegulatoryDataMiFIDPRIIPDataInvestmentTargets investmentTargetsField;

    private IBTTermSheetRegulatoryDataMiFIDPRIIPDataInvestmentHorizon investmentHorizonField;

    private IBTTermSheetRegulatoryDataMiFIDPRIIPDataDistributionStrategy distributionStrategyField;

    private IBTTermSheetRegulatoryDataMiFIDPRIIPDataSpecialRequirements specialRequirementsField;

    /// <remarks/>
    public string LeveragedInstrumentFlag
    {
        get
        {
            return this.leveragedInstrumentFlagField;
        }
        set
        {
            this.leveragedInstrumentFlagField = value;
        }
    }

    /// <remarks/>
    public byte InstrumentComplexityType
    {
        get
        {
            return this.instrumentComplexityTypeField;
        }
        set
        {
            this.instrumentComplexityTypeField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetRegulatoryDataMiFIDPRIIPDataLossBearingCapacity LossBearingCapacity
    {
        get
        {
            return this.lossBearingCapacityField;
        }
        set
        {
            this.lossBearingCapacityField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetRegulatoryDataMiFIDPRIIPDataKnowledgeExperience KnowledgeExperience
    {
        get
        {
            return this.knowledgeExperienceField;
        }
        set
        {
            this.knowledgeExperienceField = value;
        }
    }

    /// <remarks/>
    public byte RiskIndicatorType
    {
        get
        {
            return this.riskIndicatorTypeField;
        }
        set
        {
            this.riskIndicatorTypeField = value;
        }
    }

    /// <remarks/>
    public object RiskYieldProfileType
    {
        get
        {
            return this.riskYieldProfileTypeField;
        }
        set
        {
            this.riskYieldProfileTypeField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetRegulatoryDataMiFIDPRIIPDataCustomerCategory CustomerCategory
    {
        get
        {
            return this.customerCategoryField;
        }
        set
        {
            this.customerCategoryField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetRegulatoryDataMiFIDPRIIPDataInvestmentTargets InvestmentTargets
    {
        get
        {
            return this.investmentTargetsField;
        }
        set
        {
            this.investmentTargetsField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetRegulatoryDataMiFIDPRIIPDataInvestmentHorizon InvestmentHorizon
    {
        get
        {
            return this.investmentHorizonField;
        }
        set
        {
            this.investmentHorizonField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetRegulatoryDataMiFIDPRIIPDataDistributionStrategy DistributionStrategy
    {
        get
        {
            return this.distributionStrategyField;
        }
        set
        {
            this.distributionStrategyField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetRegulatoryDataMiFIDPRIIPDataSpecialRequirements SpecialRequirements
    {
        get
        {
            return this.specialRequirementsField;
        }
        set
        {
            this.specialRequirementsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryDataMiFIDPRIIPDataLossBearingCapacity
{

    private string noCapitalLossTypeField;

    private string partialCapitalLossTypeField;

    private object lossUpToCapitalPercentageField;

    private string totalCapitalLossTypeField;

    private string lossGreaterCapitalTypeField;

    /// <remarks/>
    public string NoCapitalLossType
    {
        get
        {
            return this.noCapitalLossTypeField;
        }
        set
        {
            this.noCapitalLossTypeField = value;
        }
    }

    /// <remarks/>
    public string PartialCapitalLossType
    {
        get
        {
            return this.partialCapitalLossTypeField;
        }
        set
        {
            this.partialCapitalLossTypeField = value;
        }
    }

    /// <remarks/>
    public object LossUpToCapitalPercentage
    {
        get
        {
            return this.lossUpToCapitalPercentageField;
        }
        set
        {
            this.lossUpToCapitalPercentageField = value;
        }
    }

    /// <remarks/>
    public string TotalCapitalLossType
    {
        get
        {
            return this.totalCapitalLossTypeField;
        }
        set
        {
            this.totalCapitalLossTypeField = value;
        }
    }

    /// <remarks/>
    public string LossGreaterCapitalType
    {
        get
        {
            return this.lossGreaterCapitalTypeField;
        }
        set
        {
            this.lossGreaterCapitalTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryDataMiFIDPRIIPDataKnowledgeExperience
{

    private string basicKnowledgeTypeField;

    private string informedKnowledgeTypeField;

    private string advancedKnowledgeTypeField;

    private string expertKnowledgeField;

    /// <remarks/>
    public string BasicKnowledgeType
    {
        get
        {
            return this.basicKnowledgeTypeField;
        }
        set
        {
            this.basicKnowledgeTypeField = value;
        }
    }

    /// <remarks/>
    public string InformedKnowledgeType
    {
        get
        {
            return this.informedKnowledgeTypeField;
        }
        set
        {
            this.informedKnowledgeTypeField = value;
        }
    }

    /// <remarks/>
    public string AdvancedKnowledgeType
    {
        get
        {
            return this.advancedKnowledgeTypeField;
        }
        set
        {
            this.advancedKnowledgeTypeField = value;
        }
    }

    /// <remarks/>
    public string ExpertKnowledge
    {
        get
        {
            return this.expertKnowledgeField;
        }
        set
        {
            this.expertKnowledgeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryDataMiFIDPRIIPDataCustomerCategory
{

    private string privateCustomerTypeField;

    private string professionalCustomerTypeField;

    private string qualifiedCounterpartyTypeField;

    /// <remarks/>
    public string PrivateCustomerType
    {
        get
        {
            return this.privateCustomerTypeField;
        }
        set
        {
            this.privateCustomerTypeField = value;
        }
    }

    /// <remarks/>
    public string ProfessionalCustomerType
    {
        get
        {
            return this.professionalCustomerTypeField;
        }
        set
        {
            this.professionalCustomerTypeField = value;
        }
    }

    /// <remarks/>
    public string QualifiedCounterpartyType
    {
        get
        {
            return this.qualifiedCounterpartyTypeField;
        }
        set
        {
            this.qualifiedCounterpartyTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryDataMiFIDPRIIPDataInvestmentTargets
{

    private string specificRetirementSchemeTypeField;

    private string preservationTypeField;

    private string investmentIncomeTypeField;

    private string growthTypeField;

    private object financingTypeField;

    private string hedgingTypeField;

    private string leverageTypeField;

    /// <remarks/>
    public string SpecificRetirementSchemeType
    {
        get
        {
            return this.specificRetirementSchemeTypeField;
        }
        set
        {
            this.specificRetirementSchemeTypeField = value;
        }
    }

    /// <remarks/>
    public string PreservationType
    {
        get
        {
            return this.preservationTypeField;
        }
        set
        {
            this.preservationTypeField = value;
        }
    }

    /// <remarks/>
    public string InvestmentIncomeType
    {
        get
        {
            return this.investmentIncomeTypeField;
        }
        set
        {
            this.investmentIncomeTypeField = value;
        }
    }

    /// <remarks/>
    public string GrowthType
    {
        get
        {
            return this.growthTypeField;
        }
        set
        {
            this.growthTypeField = value;
        }
    }

    /// <remarks/>
    public object FinancingType
    {
        get
        {
            return this.financingTypeField;
        }
        set
        {
            this.financingTypeField = value;
        }
    }

    /// <remarks/>
    public string HedgingType
    {
        get
        {
            return this.hedgingTypeField;
        }
        set
        {
            this.hedgingTypeField = value;
        }
    }

    /// <remarks/>
    public string LeverageType
    {
        get
        {
            return this.leverageTypeField;
        }
        set
        {
            this.leverageTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryDataMiFIDPRIIPDataInvestmentHorizon
{

    private string veryShortTermTypeField;

    private string shortTermTypeField;

    private string mediumTermTypeField;

    private string longTermTypeField;

    private string heldToMaturityTypeField;

    private ushort recommendedHoldingPeriodField;

    private string mayBeTerminatedEarlyTypeField;

    /// <remarks/>
    public string VeryShortTermType
    {
        get
        {
            return this.veryShortTermTypeField;
        }
        set
        {
            this.veryShortTermTypeField = value;
        }
    }

    /// <remarks/>
    public string ShortTermType
    {
        get
        {
            return this.shortTermTypeField;
        }
        set
        {
            this.shortTermTypeField = value;
        }
    }

    /// <remarks/>
    public string MediumTermType
    {
        get
        {
            return this.mediumTermTypeField;
        }
        set
        {
            this.mediumTermTypeField = value;
        }
    }

    /// <remarks/>
    public string LongTermType
    {
        get
        {
            return this.longTermTypeField;
        }
        set
        {
            this.longTermTypeField = value;
        }
    }

    /// <remarks/>
    public string HeldToMaturityType
    {
        get
        {
            return this.heldToMaturityTypeField;
        }
        set
        {
            this.heldToMaturityTypeField = value;
        }
    }

    /// <remarks/>
    public ushort RecommendedHoldingPeriod
    {
        get
        {
            return this.recommendedHoldingPeriodField;
        }
        set
        {
            this.recommendedHoldingPeriodField = value;
        }
    }

    /// <remarks/>
    public string MayBeTerminatedEarlyType
    {
        get
        {
            return this.mayBeTerminatedEarlyTypeField;
        }
        set
        {
            this.mayBeTerminatedEarlyTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryDataMiFIDPRIIPDataDistributionStrategy
{

    private string executionOnlyTypeField;

    private string transactionWithoutConsultingTypeField;

    private string investmentConsultingTypeField;

    private string portfolioManagementTypeField;

    /// <remarks/>
    public string ExecutionOnlyType
    {
        get
        {
            return this.executionOnlyTypeField;
        }
        set
        {
            this.executionOnlyTypeField = value;
        }
    }

    /// <remarks/>
    public string TransactionWithoutConsultingType
    {
        get
        {
            return this.transactionWithoutConsultingTypeField;
        }
        set
        {
            this.transactionWithoutConsultingTypeField = value;
        }
    }

    /// <remarks/>
    public string InvestmentConsultingType
    {
        get
        {
            return this.investmentConsultingTypeField;
        }
        set
        {
            this.investmentConsultingTypeField = value;
        }
    }

    /// <remarks/>
    public string PortfolioManagementType
    {
        get
        {
            return this.portfolioManagementTypeField;
        }
        set
        {
            this.portfolioManagementTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryDataMiFIDPRIIPDataSpecialRequirements
{

    private object greenInvestmentTypeField;

    private object ethicalInvestmentTypeField;

    private object islamicBankingTypeField;

    /// <remarks/>
    public object GreenInvestmentType
    {
        get
        {
            return this.greenInvestmentTypeField;
        }
        set
        {
            this.greenInvestmentTypeField = value;
        }
    }

    /// <remarks/>
    public object EthicalInvestmentType
    {
        get
        {
            return this.ethicalInvestmentTypeField;
        }
        set
        {
            this.ethicalInvestmentTypeField = value;
        }
    }

    /// <remarks/>
    public object IslamicBankingType
    {
        get
        {
            return this.islamicBankingTypeField;
        }
        set
        {
            this.islamicBankingTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetRegulatoryDataFIDLEGData
{

    private byte instrumentInScopeFIDLEGField;

    private byte fIDLEGDocumentationSubmissionTypeField;

    /// <remarks/>
    public byte InstrumentInScopeFIDLEG
    {
        get
        {
            return this.instrumentInScopeFIDLEGField;
        }
        set
        {
            this.instrumentInScopeFIDLEGField = value;
        }
    }

    /// <remarks/>
    public byte FIDLEGDocumentationSubmissionType
    {
        get
        {
            return this.fIDLEGDocumentationSubmissionTypeField;
        }
        set
        {
            this.fIDLEGDocumentationSubmissionTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrument
{

    private string productDescriptionURLField;

    private string productNameFullField;

    private object fISNField;

    private string productBrandField;

    private uint iBTTypeCodeField;

    private byte collateralisationTypeField;

    private string privatePlacementFlagField;

    private string listedFlagField;

    private string issueCurrencyCodeField;

    private decimal denominationField;

    private byte dayCountMethodTypeField;

    private decimal issuePriceField;

    private decimal issuePriceRateField;

    private byte instrumentQuotationTypeField;

    private object basketCoverRatioField;

    private object basketInitialPriceField;

    private object discountRateField;

    private uint issueCapitalisationField;

    private decimal maxYieldRateField;

    private string issueIncreaseFlagField;

    private ushort numberInIssueField;

    private System.DateTime redemptionDateField;

    private object ordinaryTerminationDateField;

    private string openEndFlagField;

    private string barrierHitFlagField;

    private string orderServiceFlagField;

    private string investorPutabilityFlagField;

    private string issuerCallabilityFlagField;

    private object issuerProlongationFlagField;

    private object amortisableFlagField;

    private string leverageProductFlagField;

    private object investorConversionTypeField;

    private byte mainUnderlyingAssetTypeField;

    private byte underlyingMgmtTypeField;

    private System.DateTime issueDateField;

    private object issueTimeField;

    private System.DateTime paymentDateField;

    private System.DateTime subscriptionBeginDateField;

    private System.DateTime subscriptionEndDateField;

    private System.DateTime subscriptionEndTimeField;

    private byte initialFixingDateTypeField;

    private System.DateTime initialFixingDateField;

    private byte initialFixingDayPriceTypeField;

    private System.DateTime initialFixingTimeField;

    private object initialFixingFunctionTypeField;

    private object initialFixingEndDateField;

    private object initialFixingPeriodicTypeField;

    private object initialFixingIntervalField;

    private object initialFixingIntervalTypeField;

    private byte businessDayConventionTypeField;

    private decimal bondYieldRateField;

    private byte legalSecurityTypeField;

    private byte securityRankingTypeField;

    private object conversionGuaranteeTypeField;

    private string jurisdictionAreaCodeField;

    private string legalVenueField;

    private object finalTermsIdField;

    private System.DateTime baseProspectusCreationDateField;

    private System.DateTime baseProspectusPublicationDateField;

    private System.DateTime publicOfferingDateField;

    private IBTTermSheetInstrumentInstrumentClassification[] instrumentClassificationsField;

    private IBTTermSheetInstrumentIncomeData incomeDataField;

    private IBTTermSheetInstrumentCHTaxData cHTaxDataField;

    private IBTTermSheetInstrumentEUTaxData eUTaxDataField;

    private IBTTermSheetInstrumentUSTaxData uSTaxDataField;

    private IBTTermSheetInstrumentUKTaxData uKTaxDataField;

    private IBTTermSheetInstrumentATTaxData aTTaxDataField;

    private IBTTermSheetInstrumentITTaxData iTTaxDataField;

    private IBTTermSheetInstrumentFee[] feesField;

    private IBTTermSheetInstrumentInstrumentIds instrumentIdsField;

    private IBTTermSheetInstrumentUnderlying[] underlyingsField;

    private IBTTermSheetInstrumentPayment[] paymentsField;

    private IBTTermSheetInstrumentTradingVenues tradingVenuesField;

    private IBTTermSheetInstrumentParty[] partiesField;

    private IBTTermSheetInstrumentDistributionRestriction[] distributionRestrictionsField;

    private IBTTermSheetInstrumentTransactionRestriction[] transactionRestrictionsField;

    /// <remarks/>
    public string ProductDescriptionURL
    {
        get
        {
            return this.productDescriptionURLField;
        }
        set
        {
            this.productDescriptionURLField = value;
        }
    }

    /// <remarks/>
    public string ProductNameFull
    {
        get
        {
            return this.productNameFullField;
        }
        set
        {
            this.productNameFullField = value;
        }
    }

    /// <remarks/>
    public object FISN
    {
        get
        {
            return this.fISNField;
        }
        set
        {
            this.fISNField = value;
        }
    }

    /// <remarks/>
    public string ProductBrand
    {
        get
        {
            return this.productBrandField;
        }
        set
        {
            this.productBrandField = value;
        }
    }

    /// <remarks/>
    public uint IBTTypeCode
    {
        get
        {
            return this.iBTTypeCodeField;
        }
        set
        {
            this.iBTTypeCodeField = value;
        }
    }

    /// <remarks/>
    public byte CollateralisationType
    {
        get
        {
            return this.collateralisationTypeField;
        }
        set
        {
            this.collateralisationTypeField = value;
        }
    }

    /// <remarks/>
    public string PrivatePlacementFlag
    {
        get
        {
            return this.privatePlacementFlagField;
        }
        set
        {
            this.privatePlacementFlagField = value;
        }
    }

    /// <remarks/>
    public string ListedFlag
    {
        get
        {
            return this.listedFlagField;
        }
        set
        {
            this.listedFlagField = value;
        }
    }

    /// <remarks/>
    public string IssueCurrencyCode
    {
        get
        {
            return this.issueCurrencyCodeField;
        }
        set
        {
            this.issueCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public decimal Denomination
    {
        get
        {
            return this.denominationField;
        }
        set
        {
            this.denominationField = value;
        }
    }

    /// <remarks/>
    public byte DayCountMethodType
    {
        get
        {
            return this.dayCountMethodTypeField;
        }
        set
        {
            this.dayCountMethodTypeField = value;
        }
    }

    /// <remarks/>
    public decimal IssuePrice
    {
        get
        {
            return this.issuePriceField;
        }
        set
        {
            this.issuePriceField = value;
        }
    }

    /// <remarks/>
    public decimal IssuePriceRate
    {
        get
        {
            return this.issuePriceRateField;
        }
        set
        {
            this.issuePriceRateField = value;
        }
    }

    /// <remarks/>
    public byte InstrumentQuotationType
    {
        get
        {
            return this.instrumentQuotationTypeField;
        }
        set
        {
            this.instrumentQuotationTypeField = value;
        }
    }

    /// <remarks/>
    public object BasketCoverRatio
    {
        get
        {
            return this.basketCoverRatioField;
        }
        set
        {
            this.basketCoverRatioField = value;
        }
    }

    /// <remarks/>
    public object BasketInitialPrice
    {
        get
        {
            return this.basketInitialPriceField;
        }
        set
        {
            this.basketInitialPriceField = value;
        }
    }

    /// <remarks/>
    public object DiscountRate
    {
        get
        {
            return this.discountRateField;
        }
        set
        {
            this.discountRateField = value;
        }
    }

    /// <remarks/>
    public uint IssueCapitalisation
    {
        get
        {
            return this.issueCapitalisationField;
        }
        set
        {
            this.issueCapitalisationField = value;
        }
    }

    /// <remarks/>
    public decimal MaxYieldRate
    {
        get
        {
            return this.maxYieldRateField;
        }
        set
        {
            this.maxYieldRateField = value;
        }
    }

    /// <remarks/>
    public string IssueIncreaseFlag
    {
        get
        {
            return this.issueIncreaseFlagField;
        }
        set
        {
            this.issueIncreaseFlagField = value;
        }
    }

    /// <remarks/>
    public ushort NumberInIssue
    {
        get
        {
            return this.numberInIssueField;
        }
        set
        {
            this.numberInIssueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime RedemptionDate
    {
        get
        {
            return this.redemptionDateField;
        }
        set
        {
            this.redemptionDateField = value;
        }
    }

    /// <remarks/>
    public object OrdinaryTerminationDate
    {
        get
        {
            return this.ordinaryTerminationDateField;
        }
        set
        {
            this.ordinaryTerminationDateField = value;
        }
    }

    /// <remarks/>
    public string OpenEndFlag
    {
        get
        {
            return this.openEndFlagField;
        }
        set
        {
            this.openEndFlagField = value;
        }
    }

    /// <remarks/>
    public string BarrierHitFlag
    {
        get
        {
            return this.barrierHitFlagField;
        }
        set
        {
            this.barrierHitFlagField = value;
        }
    }

    /// <remarks/>
    public string OrderServiceFlag
    {
        get
        {
            return this.orderServiceFlagField;
        }
        set
        {
            this.orderServiceFlagField = value;
        }
    }

    /// <remarks/>
    public string InvestorPutabilityFlag
    {
        get
        {
            return this.investorPutabilityFlagField;
        }
        set
        {
            this.investorPutabilityFlagField = value;
        }
    }

    /// <remarks/>
    public string IssuerCallabilityFlag
    {
        get
        {
            return this.issuerCallabilityFlagField;
        }
        set
        {
            this.issuerCallabilityFlagField = value;
        }
    }

    /// <remarks/>
    public object IssuerProlongationFlag
    {
        get
        {
            return this.issuerProlongationFlagField;
        }
        set
        {
            this.issuerProlongationFlagField = value;
        }
    }

    /// <remarks/>
    public object AmortisableFlag
    {
        get
        {
            return this.amortisableFlagField;
        }
        set
        {
            this.amortisableFlagField = value;
        }
    }

    /// <remarks/>
    public string LeverageProductFlag
    {
        get
        {
            return this.leverageProductFlagField;
        }
        set
        {
            this.leverageProductFlagField = value;
        }
    }

    /// <remarks/>
    public object InvestorConversionType
    {
        get
        {
            return this.investorConversionTypeField;
        }
        set
        {
            this.investorConversionTypeField = value;
        }
    }

    /// <remarks/>
    public byte MainUnderlyingAssetType
    {
        get
        {
            return this.mainUnderlyingAssetTypeField;
        }
        set
        {
            this.mainUnderlyingAssetTypeField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingMgmtType
    {
        get
        {
            return this.underlyingMgmtTypeField;
        }
        set
        {
            this.underlyingMgmtTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime IssueDate
    {
        get
        {
            return this.issueDateField;
        }
        set
        {
            this.issueDateField = value;
        }
    }

    /// <remarks/>
    public object IssueTime
    {
        get
        {
            return this.issueTimeField;
        }
        set
        {
            this.issueTimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime PaymentDate
    {
        get
        {
            return this.paymentDateField;
        }
        set
        {
            this.paymentDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime SubscriptionBeginDate
    {
        get
        {
            return this.subscriptionBeginDateField;
        }
        set
        {
            this.subscriptionBeginDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime SubscriptionEndDate
    {
        get
        {
            return this.subscriptionEndDateField;
        }
        set
        {
            this.subscriptionEndDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
    public System.DateTime SubscriptionEndTime
    {
        get
        {
            return this.subscriptionEndTimeField;
        }
        set
        {
            this.subscriptionEndTimeField = value;
        }
    }

    /// <remarks/>
    public byte InitialFixingDateType
    {
        get
        {
            return this.initialFixingDateTypeField;
        }
        set
        {
            this.initialFixingDateTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime InitialFixingDate
    {
        get
        {
            return this.initialFixingDateField;
        }
        set
        {
            this.initialFixingDateField = value;
        }
    }

    /// <remarks/>
    public byte InitialFixingDayPriceType
    {
        get
        {
            return this.initialFixingDayPriceTypeField;
        }
        set
        {
            this.initialFixingDayPriceTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
    public System.DateTime InitialFixingTime
    {
        get
        {
            return this.initialFixingTimeField;
        }
        set
        {
            this.initialFixingTimeField = value;
        }
    }

    /// <remarks/>
    public object InitialFixingFunctionType
    {
        get
        {
            return this.initialFixingFunctionTypeField;
        }
        set
        {
            this.initialFixingFunctionTypeField = value;
        }
    }

    /// <remarks/>
    public object InitialFixingEndDate
    {
        get
        {
            return this.initialFixingEndDateField;
        }
        set
        {
            this.initialFixingEndDateField = value;
        }
    }

    /// <remarks/>
    public object InitialFixingPeriodicType
    {
        get
        {
            return this.initialFixingPeriodicTypeField;
        }
        set
        {
            this.initialFixingPeriodicTypeField = value;
        }
    }

    /// <remarks/>
    public object InitialFixingInterval
    {
        get
        {
            return this.initialFixingIntervalField;
        }
        set
        {
            this.initialFixingIntervalField = value;
        }
    }

    /// <remarks/>
    public object InitialFixingIntervalType
    {
        get
        {
            return this.initialFixingIntervalTypeField;
        }
        set
        {
            this.initialFixingIntervalTypeField = value;
        }
    }

    /// <remarks/>
    public byte BusinessDayConventionType
    {
        get
        {
            return this.businessDayConventionTypeField;
        }
        set
        {
            this.businessDayConventionTypeField = value;
        }
    }

    /// <remarks/>
    public decimal BondYieldRate
    {
        get
        {
            return this.bondYieldRateField;
        }
        set
        {
            this.bondYieldRateField = value;
        }
    }

    /// <remarks/>
    public byte LegalSecurityType
    {
        get
        {
            return this.legalSecurityTypeField;
        }
        set
        {
            this.legalSecurityTypeField = value;
        }
    }

    /// <remarks/>
    public byte SecurityRankingType
    {
        get
        {
            return this.securityRankingTypeField;
        }
        set
        {
            this.securityRankingTypeField = value;
        }
    }

    /// <remarks/>
    public object ConversionGuaranteeType
    {
        get
        {
            return this.conversionGuaranteeTypeField;
        }
        set
        {
            this.conversionGuaranteeTypeField = value;
        }
    }

    /// <remarks/>
    public string JurisdictionAreaCode
    {
        get
        {
            return this.jurisdictionAreaCodeField;
        }
        set
        {
            this.jurisdictionAreaCodeField = value;
        }
    }

    /// <remarks/>
    public string LegalVenue
    {
        get
        {
            return this.legalVenueField;
        }
        set
        {
            this.legalVenueField = value;
        }
    }

    /// <remarks/>
    public object FinalTermsId
    {
        get
        {
            return this.finalTermsIdField;
        }
        set
        {
            this.finalTermsIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime BaseProspectusCreationDate
    {
        get
        {
            return this.baseProspectusCreationDateField;
        }
        set
        {
            this.baseProspectusCreationDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime BaseProspectusPublicationDate
    {
        get
        {
            return this.baseProspectusPublicationDateField;
        }
        set
        {
            this.baseProspectusPublicationDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime PublicOfferingDate
    {
        get
        {
            return this.publicOfferingDateField;
        }
        set
        {
            this.publicOfferingDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("InstrumentClassification", IsNullable = false)]
    public IBTTermSheetInstrumentInstrumentClassification[] InstrumentClassifications
    {
        get
        {
            return this.instrumentClassificationsField;
        }
        set
        {
            this.instrumentClassificationsField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentIncomeData IncomeData
    {
        get
        {
            return this.incomeDataField;
        }
        set
        {
            this.incomeDataField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentCHTaxData CHTaxData
    {
        get
        {
            return this.cHTaxDataField;
        }
        set
        {
            this.cHTaxDataField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentEUTaxData EUTaxData
    {
        get
        {
            return this.eUTaxDataField;
        }
        set
        {
            this.eUTaxDataField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentUSTaxData USTaxData
    {
        get
        {
            return this.uSTaxDataField;
        }
        set
        {
            this.uSTaxDataField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentUKTaxData UKTaxData
    {
        get
        {
            return this.uKTaxDataField;
        }
        set
        {
            this.uKTaxDataField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentATTaxData ATTaxData
    {
        get
        {
            return this.aTTaxDataField;
        }
        set
        {
            this.aTTaxDataField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentITTaxData ITTaxData
    {
        get
        {
            return this.iTTaxDataField;
        }
        set
        {
            this.iTTaxDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Fee", IsNullable = false)]
    public IBTTermSheetInstrumentFee[] Fees
    {
        get
        {
            return this.feesField;
        }
        set
        {
            this.feesField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentInstrumentIds InstrumentIds
    {
        get
        {
            return this.instrumentIdsField;
        }
        set
        {
            this.instrumentIdsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Underlying", IsNullable = false)]
    public IBTTermSheetInstrumentUnderlying[] Underlyings
    {
        get
        {
            return this.underlyingsField;
        }
        set
        {
            this.underlyingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Payment", IsNullable = false)]
    public IBTTermSheetInstrumentPayment[] Payments
    {
        get
        {
            return this.paymentsField;
        }
        set
        {
            this.paymentsField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentTradingVenues TradingVenues
    {
        get
        {
            return this.tradingVenuesField;
        }
        set
        {
            this.tradingVenuesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Party", IsNullable = false)]
    public IBTTermSheetInstrumentParty[] Parties
    {
        get
        {
            return this.partiesField;
        }
        set
        {
            this.partiesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("DistributionRestriction", IsNullable = false)]
    public IBTTermSheetInstrumentDistributionRestriction[] DistributionRestrictions
    {
        get
        {
            return this.distributionRestrictionsField;
        }
        set
        {
            this.distributionRestrictionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("TransactionRestriction", IsNullable = false)]
    public IBTTermSheetInstrumentTransactionRestriction[] TransactionRestrictions
    {
        get
        {
            return this.transactionRestrictionsField;
        }
        set
        {
            this.transactionRestrictionsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentInstrumentClassification
{

    private byte classificationSchemeTypeField;

    private ushort classificationValueField;

    /// <remarks/>
    public byte ClassificationSchemeType
    {
        get
        {
            return this.classificationSchemeTypeField;
        }
        set
        {
            this.classificationSchemeTypeField = value;
        }
    }

    /// <remarks/>
    public ushort ClassificationValue
    {
        get
        {
            return this.classificationValueField;
        }
        set
        {
            this.classificationValueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentIncomeData
{

    private string interestComponentFlagField;

    private object incomePeriodicTypeField;

    private byte incomeIntervalField;

    private byte incomeIntervalTypeField;

    private string interestPeriodAdjustmentFlagField;

    private decimal annualIncomeRateField;

    private System.DateTime firstPaymentDateField;

    private System.DateTime interestFromDateField;

    private object incomeValuationBusinessDaysField;

    private string firstCouponStubField;

    /// <remarks/>
    public string InterestComponentFlag
    {
        get
        {
            return this.interestComponentFlagField;
        }
        set
        {
            this.interestComponentFlagField = value;
        }
    }

    /// <remarks/>
    public object IncomePeriodicType
    {
        get
        {
            return this.incomePeriodicTypeField;
        }
        set
        {
            this.incomePeriodicTypeField = value;
        }
    }

    /// <remarks/>
    public byte IncomeInterval
    {
        get
        {
            return this.incomeIntervalField;
        }
        set
        {
            this.incomeIntervalField = value;
        }
    }

    /// <remarks/>
    public byte IncomeIntervalType
    {
        get
        {
            return this.incomeIntervalTypeField;
        }
        set
        {
            this.incomeIntervalTypeField = value;
        }
    }

    /// <remarks/>
    public string InterestPeriodAdjustmentFlag
    {
        get
        {
            return this.interestPeriodAdjustmentFlagField;
        }
        set
        {
            this.interestPeriodAdjustmentFlagField = value;
        }
    }

    /// <remarks/>
    public decimal AnnualIncomeRate
    {
        get
        {
            return this.annualIncomeRateField;
        }
        set
        {
            this.annualIncomeRateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime FirstPaymentDate
    {
        get
        {
            return this.firstPaymentDateField;
        }
        set
        {
            this.firstPaymentDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime InterestFromDate
    {
        get
        {
            return this.interestFromDateField;
        }
        set
        {
            this.interestFromDateField = value;
        }
    }

    /// <remarks/>
    public object IncomeValuationBusinessDays
    {
        get
        {
            return this.incomeValuationBusinessDaysField;
        }
        set
        {
            this.incomeValuationBusinessDaysField = value;
        }
    }

    /// <remarks/>
    public string FirstCouponStub
    {
        get
        {
            return this.firstCouponStubField;
        }
        set
        {
            this.firstCouponStubField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentCHTaxData
{

    private decimal annualInterestFractionRateField;

    private decimal interestFractionRateField;

    private decimal annualPremiumFractionRateField;

    private decimal premiumFractionRateField;

    private byte cHIUPTypeField;

    private string cHIssueStampTaxFlagField;

    private string stampTaxFeedbackFlagField;

    private string cHTurnoverStampTaxFlagField;

    private byte cHTaxTypeField;

    private decimal cHWithholdingTaxRateField;

    /// <remarks/>
    public decimal AnnualInterestFractionRate
    {
        get
        {
            return this.annualInterestFractionRateField;
        }
        set
        {
            this.annualInterestFractionRateField = value;
        }
    }

    /// <remarks/>
    public decimal InterestFractionRate
    {
        get
        {
            return this.interestFractionRateField;
        }
        set
        {
            this.interestFractionRateField = value;
        }
    }

    /// <remarks/>
    public decimal AnnualPremiumFractionRate
    {
        get
        {
            return this.annualPremiumFractionRateField;
        }
        set
        {
            this.annualPremiumFractionRateField = value;
        }
    }

    /// <remarks/>
    public decimal PremiumFractionRate
    {
        get
        {
            return this.premiumFractionRateField;
        }
        set
        {
            this.premiumFractionRateField = value;
        }
    }

    /// <remarks/>
    public byte CHIUPType
    {
        get
        {
            return this.cHIUPTypeField;
        }
        set
        {
            this.cHIUPTypeField = value;
        }
    }

    /// <remarks/>
    public string CHIssueStampTaxFlag
    {
        get
        {
            return this.cHIssueStampTaxFlagField;
        }
        set
        {
            this.cHIssueStampTaxFlagField = value;
        }
    }

    /// <remarks/>
    public string StampTaxFeedbackFlag
    {
        get
        {
            return this.stampTaxFeedbackFlagField;
        }
        set
        {
            this.stampTaxFeedbackFlagField = value;
        }
    }

    /// <remarks/>
    public string CHTurnoverStampTaxFlag
    {
        get
        {
            return this.cHTurnoverStampTaxFlagField;
        }
        set
        {
            this.cHTurnoverStampTaxFlagField = value;
        }
    }

    /// <remarks/>
    public byte CHTaxType
    {
        get
        {
            return this.cHTaxTypeField;
        }
        set
        {
            this.cHTaxTypeField = value;
        }
    }

    /// <remarks/>
    public decimal CHWithholdingTaxRate
    {
        get
        {
            return this.cHWithholdingTaxRateField;
        }
        set
        {
            this.cHWithholdingTaxRateField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentEUTaxData
{

    private byte eUTaxTypeField;

    private byte eUTaxApplicabilityTypeField;

    /// <remarks/>
    public byte EUTaxType
    {
        get
        {
            return this.eUTaxTypeField;
        }
        set
        {
            this.eUTaxTypeField = value;
        }
    }

    /// <remarks/>
    public byte EUTaxApplicabilityType
    {
        get
        {
            return this.eUTaxApplicabilityTypeField;
        }
        set
        {
            this.eUTaxApplicabilityTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentUSTaxData
{

    private object uSTaxTypeField;

    private IBTTermSheetInstrumentUSTaxDataIRS871m iRS871mField;

    /// <remarks/>
    public object USTaxType
    {
        get
        {
            return this.uSTaxTypeField;
        }
        set
        {
            this.uSTaxTypeField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentUSTaxDataIRS871m IRS871m
    {
        get
        {
            return this.iRS871mField;
        }
        set
        {
            this.iRS871mField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentUSTaxDataIRS871m
{

    private byte contractComplexityType871mField;

    private byte issuersInstrumentInScope871mField;

    private string taxPaidByIssuerFlag871mField;

    /// <remarks/>
    public byte ContractComplexityType871m
    {
        get
        {
            return this.contractComplexityType871mField;
        }
        set
        {
            this.contractComplexityType871mField = value;
        }
    }

    /// <remarks/>
    public byte IssuersInstrumentInScope871m
    {
        get
        {
            return this.issuersInstrumentInScope871mField;
        }
        set
        {
            this.issuersInstrumentInScope871mField = value;
        }
    }

    /// <remarks/>
    public string TaxPaidByIssuerFlag871m
    {
        get
        {
            return this.taxPaidByIssuerFlag871mField;
        }
        set
        {
            this.taxPaidByIssuerFlag871mField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentUKTaxData
{

    private byte uKDDSField;

    private byte uKCapitalGainsTaxField;

    /// <remarks/>
    public byte UKDDS
    {
        get
        {
            return this.uKDDSField;
        }
        set
        {
            this.uKDDSField = value;
        }
    }

    /// <remarks/>
    public byte UKCapitalGainsTax
    {
        get
        {
            return this.uKCapitalGainsTaxField;
        }
        set
        {
            this.uKCapitalGainsTaxField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentATTaxData
{

    private object aTKEStField;

    private object aTInvestFundField;

    /// <remarks/>
    public object ATKESt
    {
        get
        {
            return this.aTKEStField;
        }
        set
        {
            this.aTKEStField = value;
        }
    }

    /// <remarks/>
    public object ATInvestFund
    {
        get
        {
            return this.aTInvestFundField;
        }
        set
        {
            this.aTInvestFundField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentITTaxData
{

    private byte iTTransactionTaxField;

    /// <remarks/>
    public byte ITTransactionTax
    {
        get
        {
            return this.iTTransactionTaxField;
        }
        set
        {
            this.iTTransactionTaxField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentFee
{

    private byte feeTypeField;

    private byte feeBaseTypeField;

    private string feeRateField;

    private string annualFeeRateField;

    private string feeValueField;

    private string feePaymentCurrencyCodeField;

    private object feePaymentPeriodicTypeField;

    private object feePaymentIntervalField;

    private object feePaymentIntervalTypeField;

    /// <remarks/>
    public byte FeeType
    {
        get
        {
            return this.feeTypeField;
        }
        set
        {
            this.feeTypeField = value;
        }
    }

    /// <remarks/>
    public byte FeeBaseType
    {
        get
        {
            return this.feeBaseTypeField;
        }
        set
        {
            this.feeBaseTypeField = value;
        }
    }

    /// <remarks/>
    public string FeeRate
    {
        get
        {
            return this.feeRateField;
        }
        set
        {
            this.feeRateField = value;
        }
    }

    /// <remarks/>
    public string AnnualFeeRate
    {
        get
        {
            return this.annualFeeRateField;
        }
        set
        {
            this.annualFeeRateField = value;
        }
    }

    /// <remarks/>
    public string FeeValue
    {
        get
        {
            return this.feeValueField;
        }
        set
        {
            this.feeValueField = value;
        }
    }

    /// <remarks/>
    public string FeePaymentCurrencyCode
    {
        get
        {
            return this.feePaymentCurrencyCodeField;
        }
        set
        {
            this.feePaymentCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public object FeePaymentPeriodicType
    {
        get
        {
            return this.feePaymentPeriodicTypeField;
        }
        set
        {
            this.feePaymentPeriodicTypeField = value;
        }
    }

    /// <remarks/>
    public object FeePaymentInterval
    {
        get
        {
            return this.feePaymentIntervalField;
        }
        set
        {
            this.feePaymentIntervalField = value;
        }
    }

    /// <remarks/>
    public object FeePaymentIntervalType
    {
        get
        {
            return this.feePaymentIntervalTypeField;
        }
        set
        {
            this.feePaymentIntervalTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentInstrumentIds
{

    private IBTTermSheetInstrumentInstrumentIdsInstrumentId[] instrumentIdField;

    private IBTTermSheetInstrumentInstrumentIdsReutersInstrumentId reutersInstrumentIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InstrumentId")]
    public IBTTermSheetInstrumentInstrumentIdsInstrumentId[] InstrumentId
    {
        get
        {
            return this.instrumentIdField;
        }
        set
        {
            this.instrumentIdField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentInstrumentIdsReutersInstrumentId ReutersInstrumentId
    {
        get
        {
            return this.reutersInstrumentIdField;
        }
        set
        {
            this.reutersInstrumentIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentInstrumentIdsInstrumentId
{

    private string idSchemeCodeField;

    private string idValueField;

    /// <remarks/>
    public string IdSchemeCode
    {
        get
        {
            return this.idSchemeCodeField;
        }
        set
        {
            this.idSchemeCodeField = value;
        }
    }

    /// <remarks/>
    public string IdValue
    {
        get
        {
            return this.idValueField;
        }
        set
        {
            this.idValueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentInstrumentIdsReutersInstrumentId
{

    private string rICodeField;

    /// <remarks/>
    public string RICode
    {
        get
        {
            return this.rICodeField;
        }
        set
        {
            this.rICodeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentUnderlying
{

    private uint underlyingKeyField;

    private string nameShortField;

    private string nameLongField;

    private string principalFlagField;

    private string incomeFlagField;

    private string paymentLegFlagField;

    private byte underlyingRoleTypeField;

    private byte underlyingQuotedPriceTypeField;

    private object fXPriceInverseFlagField;

    private object fXUnderlyingCurrencyCodeField;

    private string quotedCurrencyCodeField;

    private byte underlyingAssetTypeField;

    private byte underlyingTypeField;

    private byte underlyingSubTypeField;

    private string rolloverFlagField;

    private string underlyingExchangeCodeField;

    private object monetiserAmountField;

    private object monetiserCurrencyCodeField;

    private decimal initialReferencePriceField;

    private object adjustedReferencePriceField;

    private decimal latestReferencePriceField;

    private object finalReferencePriceField;

    private decimal underlyingCoverRatioField;

    private object underlyingReverseCoverRatioField;

    private object currentAmountField;

    private byte currentWeightField;

    private object currencyPairSymbolField;

    private object currencyPairSpotRateField;

    private object currencyPairFeedTypeField;

    private object currencyPairSourcePageField;

    private byte underlyingPriceFeedTypeField;

    private string underlyingPriceSourcePageField;

    private object settlementISINField;

    private object corporateActionTypeField;

    private object underlyingTextField;

    private decimal deltaAtIssueField;

    private System.DateTime effectiveFromDateDeltaAtIssueField;

    private object nrOfSharesInInitialHedgeField;

    private object effectiveFromDateSharesInHedgeField;

    private object indexSponsorField;

    private object uBSNonDeliverableFlagField;

    private decimal breakEvenField;

    private decimal deltaField;

    private object deltaPercentageField;

    private object leverageFactorField;

    private object volatilityField;

    private IBTTermSheetInstrumentUnderlyingInstrumentIds instrumentIdsField;

    /// <remarks/>
    public uint UnderlyingKey
    {
        get
        {
            return this.underlyingKeyField;
        }
        set
        {
            this.underlyingKeyField = value;
        }
    }

    /// <remarks/>
    public string NameShort
    {
        get
        {
            return this.nameShortField;
        }
        set
        {
            this.nameShortField = value;
        }
    }

    /// <remarks/>
    public string NameLong
    {
        get
        {
            return this.nameLongField;
        }
        set
        {
            this.nameLongField = value;
        }
    }

    /// <remarks/>
    public string PrincipalFlag
    {
        get
        {
            return this.principalFlagField;
        }
        set
        {
            this.principalFlagField = value;
        }
    }

    /// <remarks/>
    public string IncomeFlag
    {
        get
        {
            return this.incomeFlagField;
        }
        set
        {
            this.incomeFlagField = value;
        }
    }

    /// <remarks/>
    public string PaymentLegFlag
    {
        get
        {
            return this.paymentLegFlagField;
        }
        set
        {
            this.paymentLegFlagField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingRoleType
    {
        get
        {
            return this.underlyingRoleTypeField;
        }
        set
        {
            this.underlyingRoleTypeField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingQuotedPriceType
    {
        get
        {
            return this.underlyingQuotedPriceTypeField;
        }
        set
        {
            this.underlyingQuotedPriceTypeField = value;
        }
    }

    /// <remarks/>
    public object FXPriceInverseFlag
    {
        get
        {
            return this.fXPriceInverseFlagField;
        }
        set
        {
            this.fXPriceInverseFlagField = value;
        }
    }

    /// <remarks/>
    public object FXUnderlyingCurrencyCode
    {
        get
        {
            return this.fXUnderlyingCurrencyCodeField;
        }
        set
        {
            this.fXUnderlyingCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public string QuotedCurrencyCode
    {
        get
        {
            return this.quotedCurrencyCodeField;
        }
        set
        {
            this.quotedCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingAssetType
    {
        get
        {
            return this.underlyingAssetTypeField;
        }
        set
        {
            this.underlyingAssetTypeField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingType
    {
        get
        {
            return this.underlyingTypeField;
        }
        set
        {
            this.underlyingTypeField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingSubType
    {
        get
        {
            return this.underlyingSubTypeField;
        }
        set
        {
            this.underlyingSubTypeField = value;
        }
    }

    /// <remarks/>
    public string RolloverFlag
    {
        get
        {
            return this.rolloverFlagField;
        }
        set
        {
            this.rolloverFlagField = value;
        }
    }

    /// <remarks/>
    public string UnderlyingExchangeCode
    {
        get
        {
            return this.underlyingExchangeCodeField;
        }
        set
        {
            this.underlyingExchangeCodeField = value;
        }
    }

    /// <remarks/>
    public object MonetiserAmount
    {
        get
        {
            return this.monetiserAmountField;
        }
        set
        {
            this.monetiserAmountField = value;
        }
    }

    /// <remarks/>
    public object MonetiserCurrencyCode
    {
        get
        {
            return this.monetiserCurrencyCodeField;
        }
        set
        {
            this.monetiserCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public decimal InitialReferencePrice
    {
        get
        {
            return this.initialReferencePriceField;
        }
        set
        {
            this.initialReferencePriceField = value;
        }
    }

    /// <remarks/>
    public object AdjustedReferencePrice
    {
        get
        {
            return this.adjustedReferencePriceField;
        }
        set
        {
            this.adjustedReferencePriceField = value;
        }
    }

    /// <remarks/>
    public decimal LatestReferencePrice
    {
        get
        {
            return this.latestReferencePriceField;
        }
        set
        {
            this.latestReferencePriceField = value;
        }
    }

    /// <remarks/>
    public object FinalReferencePrice
    {
        get
        {
            return this.finalReferencePriceField;
        }
        set
        {
            this.finalReferencePriceField = value;
        }
    }

    /// <remarks/>
    public decimal UnderlyingCoverRatio
    {
        get
        {
            return this.underlyingCoverRatioField;
        }
        set
        {
            this.underlyingCoverRatioField = value;
        }
    }

    /// <remarks/>
    public object UnderlyingReverseCoverRatio
    {
        get
        {
            return this.underlyingReverseCoverRatioField;
        }
        set
        {
            this.underlyingReverseCoverRatioField = value;
        }
    }

    /// <remarks/>
    public object CurrentAmount
    {
        get
        {
            return this.currentAmountField;
        }
        set
        {
            this.currentAmountField = value;
        }
    }

    /// <remarks/>
    public byte CurrentWeight
    {
        get
        {
            return this.currentWeightField;
        }
        set
        {
            this.currentWeightField = value;
        }
    }

    /// <remarks/>
    public object CurrencyPairSymbol
    {
        get
        {
            return this.currencyPairSymbolField;
        }
        set
        {
            this.currencyPairSymbolField = value;
        }
    }

    /// <remarks/>
    public object CurrencyPairSpotRate
    {
        get
        {
            return this.currencyPairSpotRateField;
        }
        set
        {
            this.currencyPairSpotRateField = value;
        }
    }

    /// <remarks/>
    public object CurrencyPairFeedType
    {
        get
        {
            return this.currencyPairFeedTypeField;
        }
        set
        {
            this.currencyPairFeedTypeField = value;
        }
    }

    /// <remarks/>
    public object CurrencyPairSourcePage
    {
        get
        {
            return this.currencyPairSourcePageField;
        }
        set
        {
            this.currencyPairSourcePageField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingPriceFeedType
    {
        get
        {
            return this.underlyingPriceFeedTypeField;
        }
        set
        {
            this.underlyingPriceFeedTypeField = value;
        }
    }

    /// <remarks/>
    public string UnderlyingPriceSourcePage
    {
        get
        {
            return this.underlyingPriceSourcePageField;
        }
        set
        {
            this.underlyingPriceSourcePageField = value;
        }
    }

    /// <remarks/>
    public object SettlementISIN
    {
        get
        {
            return this.settlementISINField;
        }
        set
        {
            this.settlementISINField = value;
        }
    }

    /// <remarks/>
    public object CorporateActionType
    {
        get
        {
            return this.corporateActionTypeField;
        }
        set
        {
            this.corporateActionTypeField = value;
        }
    }

    /// <remarks/>
    public object UnderlyingText
    {
        get
        {
            return this.underlyingTextField;
        }
        set
        {
            this.underlyingTextField = value;
        }
    }

    /// <remarks/>
    public decimal DeltaAtIssue
    {
        get
        {
            return this.deltaAtIssueField;
        }
        set
        {
            this.deltaAtIssueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime EffectiveFromDateDeltaAtIssue
    {
        get
        {
            return this.effectiveFromDateDeltaAtIssueField;
        }
        set
        {
            this.effectiveFromDateDeltaAtIssueField = value;
        }
    }

    /// <remarks/>
    public object NrOfSharesInInitialHedge
    {
        get
        {
            return this.nrOfSharesInInitialHedgeField;
        }
        set
        {
            this.nrOfSharesInInitialHedgeField = value;
        }
    }

    /// <remarks/>
    public object EffectiveFromDateSharesInHedge
    {
        get
        {
            return this.effectiveFromDateSharesInHedgeField;
        }
        set
        {
            this.effectiveFromDateSharesInHedgeField = value;
        }
    }

    /// <remarks/>
    public object IndexSponsor
    {
        get
        {
            return this.indexSponsorField;
        }
        set
        {
            this.indexSponsorField = value;
        }
    }

    /// <remarks/>
    public object UBSNonDeliverableFlag
    {
        get
        {
            return this.uBSNonDeliverableFlagField;
        }
        set
        {
            this.uBSNonDeliverableFlagField = value;
        }
    }

    /// <remarks/>
    public decimal BreakEven
    {
        get
        {
            return this.breakEvenField;
        }
        set
        {
            this.breakEvenField = value;
        }
    }

    /// <remarks/>
    public decimal Delta
    {
        get
        {
            return this.deltaField;
        }
        set
        {
            this.deltaField = value;
        }
    }

    /// <remarks/>
    public object DeltaPercentage
    {
        get
        {
            return this.deltaPercentageField;
        }
        set
        {
            this.deltaPercentageField = value;
        }
    }

    /// <remarks/>
    public object LeverageFactor
    {
        get
        {
            return this.leverageFactorField;
        }
        set
        {
            this.leverageFactorField = value;
        }
    }

    /// <remarks/>
    public object Volatility
    {
        get
        {
            return this.volatilityField;
        }
        set
        {
            this.volatilityField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentUnderlyingInstrumentIds InstrumentIds
    {
        get
        {
            return this.instrumentIdsField;
        }
        set
        {
            this.instrumentIdsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentUnderlyingInstrumentIds
{

    private IBTTermSheetInstrumentUnderlyingInstrumentIdsInstrumentId[] instrumentIdField;

    private IBTTermSheetInstrumentUnderlyingInstrumentIdsBloombergInstrumentId bloombergInstrumentIdField;

    private IBTTermSheetInstrumentUnderlyingInstrumentIdsReutersInstrumentId reutersInstrumentIdField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InstrumentId")]
    public IBTTermSheetInstrumentUnderlyingInstrumentIdsInstrumentId[] InstrumentId
    {
        get
        {
            return this.instrumentIdField;
        }
        set
        {
            this.instrumentIdField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentUnderlyingInstrumentIdsBloombergInstrumentId BloombergInstrumentId
    {
        get
        {
            return this.bloombergInstrumentIdField;
        }
        set
        {
            this.bloombergInstrumentIdField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentUnderlyingInstrumentIdsReutersInstrumentId ReutersInstrumentId
    {
        get
        {
            return this.reutersInstrumentIdField;
        }
        set
        {
            this.reutersInstrumentIdField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentUnderlyingInstrumentIdsInstrumentId
{

    private string idSchemeCodeField;

    private string idValueField;

    /// <remarks/>
    public string IdSchemeCode
    {
        get
        {
            return this.idSchemeCodeField;
        }
        set
        {
            this.idSchemeCodeField = value;
        }
    }

    /// <remarks/>
    public string IdValue
    {
        get
        {
            return this.idValueField;
        }
        set
        {
            this.idValueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentUnderlyingInstrumentIdsBloombergInstrumentId
{

    private string bBTickerSymbolField;

    private string bBExchangeCodeField;

    private string bBMarketSectorCodeField;

    /// <remarks/>
    public string BBTickerSymbol
    {
        get
        {
            return this.bBTickerSymbolField;
        }
        set
        {
            this.bBTickerSymbolField = value;
        }
    }

    /// <remarks/>
    public string BBExchangeCode
    {
        get
        {
            return this.bBExchangeCodeField;
        }
        set
        {
            this.bBExchangeCodeField = value;
        }
    }

    /// <remarks/>
    public string BBMarketSectorCode
    {
        get
        {
            return this.bBMarketSectorCodeField;
        }
        set
        {
            this.bBMarketSectorCodeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentUnderlyingInstrumentIdsReutersInstrumentId
{

    private string rICodeField;

    /// <remarks/>
    public string RICode
    {
        get
        {
            return this.rICodeField;
        }
        set
        {
            this.rICodeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentPayment
{

    private object[] itemsField;

    private ItemsChoiceType1[] itemsElementNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BarrierDefinitions", typeof(IBTTermSheetInstrumentPaymentBarrierDefinitions))]
    [System.Xml.Serialization.XmlElementAttribute("CashDefinition", typeof(IBTTermSheetInstrumentPaymentCashDefinition))]
    [System.Xml.Serialization.XmlElementAttribute("CurrencyPairFixingDate", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("CurrencyPairFixingTime", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("CurrentDenomination", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("DependUnderlyingRoleType", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("DetachmentType", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("EarningBeginDate", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("EarningEndDate", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("EarningNumberOfDays", typeof(ushort))]
    [System.Xml.Serialization.XmlElementAttribute("EarningSpecificationType", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("FractionMgmtTyp", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("FractionMgmtType", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("IncomeType", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentCapLevel", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentCapRate", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentCutoff", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentDescription", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentEligibilityDate", typeof(System.DateTime), DataType = "date")]
    [System.Xml.Serialization.XmlElementAttribute("PaymentExDate", typeof(System.DateTime), DataType = "date")]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFixingDate", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFixingDateType", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFixingDayPriceType", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFixingEndDate", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFixingFunctionType", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFixingInterval", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFixingIntervalType", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFixingPeriodicType", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFixingTime", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFloorLevel", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentFloorRate", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentTriggerFlag", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentType", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentValueDate", typeof(System.DateTime), DataType = "date")]
    [System.Xml.Serialization.XmlElementAttribute("PaymentValueDays", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentValueDaysType", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("SettlementType", typeof(byte))]
    [System.Xml.Serialization.XmlElementAttribute("StrikeDefinitions", typeof(IBTTermSheetInstrumentPaymentStrikeDefinitions))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType1[] ItemsElementName
    {
        get
        {
            return this.itemsElementNameField;
        }
        set
        {
            this.itemsElementNameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentPaymentBarrierDefinitions
{

    private IBTTermSheetInstrumentPaymentBarrierDefinitionsBarrierDefinition barrierDefinitionField;

    /// <remarks/>
    public IBTTermSheetInstrumentPaymentBarrierDefinitionsBarrierDefinition BarrierDefinition
    {
        get
        {
            return this.barrierDefinitionField;
        }
        set
        {
            this.barrierDefinitionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentPaymentBarrierDefinitionsBarrierDefinition
{

    private byte affectedStrikeDefinitionKeyField;

    private byte barrierTypeField;

    private byte comparatorTypeField;

    private decimal barrierRateField;

    private object barrierUpperRateField;

    private byte quantifierTypeField;

    private byte quantifierCountField;

    private object barrierHitOrExcessReservoirField;

    private byte underlyingSelectionTypeField;

    private byte underlyingValuationTypeField;

    private byte monitorPriceTypeField;

    private System.DateTime observationBeginDateField;

    private System.DateTime observationEndDateField;

    private object observationDaysTypeField;

    private object variableBarrierFlagField;

    private object barrierEventValueDateField;

    private object barrierEventValueDaysField;

    private object barrierEventValueDaysTypeField;

    private decimal paymentRateField;

    private decimal paymentAmountField;

    private string paymentCurrencyCodeField;

    private object residualRateField;

    private object residualAmountField;

    private IBTTermSheetInstrumentPaymentBarrierDefinitionsBarrierDefinitionBarrierDetail[] barrierDetailsField;

    /// <remarks/>
    public byte AffectedStrikeDefinitionKey
    {
        get
        {
            return this.affectedStrikeDefinitionKeyField;
        }
        set
        {
            this.affectedStrikeDefinitionKeyField = value;
        }
    }

    /// <remarks/>
    public byte BarrierType
    {
        get
        {
            return this.barrierTypeField;
        }
        set
        {
            this.barrierTypeField = value;
        }
    }

    /// <remarks/>
    public byte ComparatorType
    {
        get
        {
            return this.comparatorTypeField;
        }
        set
        {
            this.comparatorTypeField = value;
        }
    }

    /// <remarks/>
    public decimal BarrierRate
    {
        get
        {
            return this.barrierRateField;
        }
        set
        {
            this.barrierRateField = value;
        }
    }

    /// <remarks/>
    public object BarrierUpperRate
    {
        get
        {
            return this.barrierUpperRateField;
        }
        set
        {
            this.barrierUpperRateField = value;
        }
    }

    /// <remarks/>
    public byte QuantifierType
    {
        get
        {
            return this.quantifierTypeField;
        }
        set
        {
            this.quantifierTypeField = value;
        }
    }

    /// <remarks/>
    public byte QuantifierCount
    {
        get
        {
            return this.quantifierCountField;
        }
        set
        {
            this.quantifierCountField = value;
        }
    }

    /// <remarks/>
    public object BarrierHitOrExcessReservoir
    {
        get
        {
            return this.barrierHitOrExcessReservoirField;
        }
        set
        {
            this.barrierHitOrExcessReservoirField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingSelectionType
    {
        get
        {
            return this.underlyingSelectionTypeField;
        }
        set
        {
            this.underlyingSelectionTypeField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingValuationType
    {
        get
        {
            return this.underlyingValuationTypeField;
        }
        set
        {
            this.underlyingValuationTypeField = value;
        }
    }

    /// <remarks/>
    public byte MonitorPriceType
    {
        get
        {
            return this.monitorPriceTypeField;
        }
        set
        {
            this.monitorPriceTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ObservationBeginDate
    {
        get
        {
            return this.observationBeginDateField;
        }
        set
        {
            this.observationBeginDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ObservationEndDate
    {
        get
        {
            return this.observationEndDateField;
        }
        set
        {
            this.observationEndDateField = value;
        }
    }

    /// <remarks/>
    public object ObservationDaysType
    {
        get
        {
            return this.observationDaysTypeField;
        }
        set
        {
            this.observationDaysTypeField = value;
        }
    }

    /// <remarks/>
    public object VariableBarrierFlag
    {
        get
        {
            return this.variableBarrierFlagField;
        }
        set
        {
            this.variableBarrierFlagField = value;
        }
    }

    /// <remarks/>
    public object BarrierEventValueDate
    {
        get
        {
            return this.barrierEventValueDateField;
        }
        set
        {
            this.barrierEventValueDateField = value;
        }
    }

    /// <remarks/>
    public object BarrierEventValueDays
    {
        get
        {
            return this.barrierEventValueDaysField;
        }
        set
        {
            this.barrierEventValueDaysField = value;
        }
    }

    /// <remarks/>
    public object BarrierEventValueDaysType
    {
        get
        {
            return this.barrierEventValueDaysTypeField;
        }
        set
        {
            this.barrierEventValueDaysTypeField = value;
        }
    }

    /// <remarks/>
    public decimal PaymentRate
    {
        get
        {
            return this.paymentRateField;
        }
        set
        {
            this.paymentRateField = value;
        }
    }

    /// <remarks/>
    public decimal PaymentAmount
    {
        get
        {
            return this.paymentAmountField;
        }
        set
        {
            this.paymentAmountField = value;
        }
    }

    /// <remarks/>
    public string PaymentCurrencyCode
    {
        get
        {
            return this.paymentCurrencyCodeField;
        }
        set
        {
            this.paymentCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public object ResidualRate
    {
        get
        {
            return this.residualRateField;
        }
        set
        {
            this.residualRateField = value;
        }
    }

    /// <remarks/>
    public object ResidualAmount
    {
        get
        {
            return this.residualAmountField;
        }
        set
        {
            this.residualAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("BarrierDetail", IsNullable = false)]
    public IBTTermSheetInstrumentPaymentBarrierDefinitionsBarrierDefinitionBarrierDetail[] BarrierDetails
    {
        get
        {
            return this.barrierDetailsField;
        }
        set
        {
            this.barrierDetailsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentPaymentBarrierDefinitionsBarrierDefinitionBarrierDetail
{

    private uint underlyingKeyField;

    private decimal barrierLevelField;

    private object barrierUpperLevelField;

    private string barrierCurrencyCodeField;

    private object barrierFixingDateTypeField;

    private object barrierFixingDateField;

    private object barrierHitDateField;

    private object barrierHitTimeField;

    private object barrierHitLevelField;

    private object barrierFixingDayPriceTypeField;

    private object barrierFixingTimeField;

    private object barrierFixingFunctionTypeField;

    private object barrierFixingEndDateField;

    private object barrierFixingPeriodicTypeField;

    private object barrierFixingIntervalField;

    private object barrierFixingIntervalTypeField;

    /// <remarks/>
    public uint UnderlyingKey
    {
        get
        {
            return this.underlyingKeyField;
        }
        set
        {
            this.underlyingKeyField = value;
        }
    }

    /// <remarks/>
    public decimal BarrierLevel
    {
        get
        {
            return this.barrierLevelField;
        }
        set
        {
            this.barrierLevelField = value;
        }
    }

    /// <remarks/>
    public object BarrierUpperLevel
    {
        get
        {
            return this.barrierUpperLevelField;
        }
        set
        {
            this.barrierUpperLevelField = value;
        }
    }

    /// <remarks/>
    public string BarrierCurrencyCode
    {
        get
        {
            return this.barrierCurrencyCodeField;
        }
        set
        {
            this.barrierCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public object BarrierFixingDateType
    {
        get
        {
            return this.barrierFixingDateTypeField;
        }
        set
        {
            this.barrierFixingDateTypeField = value;
        }
    }

    /// <remarks/>
    public object BarrierFixingDate
    {
        get
        {
            return this.barrierFixingDateField;
        }
        set
        {
            this.barrierFixingDateField = value;
        }
    }

    /// <remarks/>
    public object BarrierHitDate
    {
        get
        {
            return this.barrierHitDateField;
        }
        set
        {
            this.barrierHitDateField = value;
        }
    }

    /// <remarks/>
    public object BarrierHitTime
    {
        get
        {
            return this.barrierHitTimeField;
        }
        set
        {
            this.barrierHitTimeField = value;
        }
    }

    /// <remarks/>
    public object BarrierHitLevel
    {
        get
        {
            return this.barrierHitLevelField;
        }
        set
        {
            this.barrierHitLevelField = value;
        }
    }

    /// <remarks/>
    public object BarrierFixingDayPriceType
    {
        get
        {
            return this.barrierFixingDayPriceTypeField;
        }
        set
        {
            this.barrierFixingDayPriceTypeField = value;
        }
    }

    /// <remarks/>
    public object BarrierFixingTime
    {
        get
        {
            return this.barrierFixingTimeField;
        }
        set
        {
            this.barrierFixingTimeField = value;
        }
    }

    /// <remarks/>
    public object BarrierFixingFunctionType
    {
        get
        {
            return this.barrierFixingFunctionTypeField;
        }
        set
        {
            this.barrierFixingFunctionTypeField = value;
        }
    }

    /// <remarks/>
    public object BarrierFixingEndDate
    {
        get
        {
            return this.barrierFixingEndDateField;
        }
        set
        {
            this.barrierFixingEndDateField = value;
        }
    }

    /// <remarks/>
    public object BarrierFixingPeriodicType
    {
        get
        {
            return this.barrierFixingPeriodicTypeField;
        }
        set
        {
            this.barrierFixingPeriodicTypeField = value;
        }
    }

    /// <remarks/>
    public object BarrierFixingInterval
    {
        get
        {
            return this.barrierFixingIntervalField;
        }
        set
        {
            this.barrierFixingIntervalField = value;
        }
    }

    /// <remarks/>
    public object BarrierFixingIntervalType
    {
        get
        {
            return this.barrierFixingIntervalTypeField;
        }
        set
        {
            this.barrierFixingIntervalTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentPaymentCashDefinition
{

    private object[] itemsField;

    private ItemsChoiceType[] itemsElementNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentAmount", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentCurrencyCode", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentInterestAmount", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentInterestRate", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentInterestRateProRata", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentPremiumRate", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentPremiumRateProRata", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentRate", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentRateProRata", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("PaymentWithholdingTaxBaseAmount", typeof(byte))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName
    {
        get
        {
            return this.itemsElementNameField;
        }
        set
        {
            this.itemsElementNameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.vontobel.com/dataservice/v1.0", IncludeInSchema = false)]
public enum ItemsChoiceType
{

    /// <remarks/>
    PaymentAmount,

    /// <remarks/>
    PaymentCurrencyCode,

    /// <remarks/>
    PaymentInterestAmount,

    /// <remarks/>
    PaymentInterestRate,

    /// <remarks/>
    PaymentInterestRateProRata,

    /// <remarks/>
    PaymentPremiumRate,

    /// <remarks/>
    PaymentPremiumRateProRata,

    /// <remarks/>
    PaymentRate,

    /// <remarks/>
    PaymentRateProRata,

    /// <remarks/>
    PaymentWithholdingTaxBaseAmount,
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentPaymentStrikeDefinitions
{

    private IBTTermSheetInstrumentPaymentStrikeDefinitionsStrikeDefinition strikeDefinitionField;

    /// <remarks/>
    public IBTTermSheetInstrumentPaymentStrikeDefinitionsStrikeDefinition StrikeDefinition
    {
        get
        {
            return this.strikeDefinitionField;
        }
        set
        {
            this.strikeDefinitionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentPaymentStrikeDefinitionsStrikeDefinition
{

    private byte strikeDefinitionKeyField;

    private byte strikeTypeField;

    private byte strikeComparatorTypeField;

    private decimal strikeRateField;

    private object contractAmountField;

    private byte underlyingSelectionTypeField;

    private byte underlyingValuationTypeField;

    private System.DateTime exerciseDateField;

    private System.DateTime exerciseEndDateField;

    private object exercisePeriodicTypeField;

    private object exerciseIntervalField;

    private object exerciseIntervalTypeField;

    private byte monitorPriceTypeField;

    private object variableStrikeFlagField;

    private object strikeParticipationScaleField;

    private IBTTermSheetInstrumentPaymentStrikeDefinitionsStrikeDefinitionStrikeDetail[] strikeDetailsField;

    /// <remarks/>
    public byte StrikeDefinitionKey
    {
        get
        {
            return this.strikeDefinitionKeyField;
        }
        set
        {
            this.strikeDefinitionKeyField = value;
        }
    }

    /// <remarks/>
    public byte StrikeType
    {
        get
        {
            return this.strikeTypeField;
        }
        set
        {
            this.strikeTypeField = value;
        }
    }

    /// <remarks/>
    public byte StrikeComparatorType
    {
        get
        {
            return this.strikeComparatorTypeField;
        }
        set
        {
            this.strikeComparatorTypeField = value;
        }
    }

    /// <remarks/>
    public decimal StrikeRate
    {
        get
        {
            return this.strikeRateField;
        }
        set
        {
            this.strikeRateField = value;
        }
    }

    /// <remarks/>
    public object ContractAmount
    {
        get
        {
            return this.contractAmountField;
        }
        set
        {
            this.contractAmountField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingSelectionType
    {
        get
        {
            return this.underlyingSelectionTypeField;
        }
        set
        {
            this.underlyingSelectionTypeField = value;
        }
    }

    /// <remarks/>
    public byte UnderlyingValuationType
    {
        get
        {
            return this.underlyingValuationTypeField;
        }
        set
        {
            this.underlyingValuationTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ExerciseDate
    {
        get
        {
            return this.exerciseDateField;
        }
        set
        {
            this.exerciseDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ExerciseEndDate
    {
        get
        {
            return this.exerciseEndDateField;
        }
        set
        {
            this.exerciseEndDateField = value;
        }
    }

    /// <remarks/>
    public object ExercisePeriodicType
    {
        get
        {
            return this.exercisePeriodicTypeField;
        }
        set
        {
            this.exercisePeriodicTypeField = value;
        }
    }

    /// <remarks/>
    public object ExerciseInterval
    {
        get
        {
            return this.exerciseIntervalField;
        }
        set
        {
            this.exerciseIntervalField = value;
        }
    }

    /// <remarks/>
    public object ExerciseIntervalType
    {
        get
        {
            return this.exerciseIntervalTypeField;
        }
        set
        {
            this.exerciseIntervalTypeField = value;
        }
    }

    /// <remarks/>
    public byte MonitorPriceType
    {
        get
        {
            return this.monitorPriceTypeField;
        }
        set
        {
            this.monitorPriceTypeField = value;
        }
    }

    /// <remarks/>
    public object VariableStrikeFlag
    {
        get
        {
            return this.variableStrikeFlagField;
        }
        set
        {
            this.variableStrikeFlagField = value;
        }
    }

    /// <remarks/>
    public object StrikeParticipationScale
    {
        get
        {
            return this.strikeParticipationScaleField;
        }
        set
        {
            this.strikeParticipationScaleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("StrikeDetail", IsNullable = false)]
    public IBTTermSheetInstrumentPaymentStrikeDefinitionsStrikeDefinitionStrikeDetail[] StrikeDetails
    {
        get
        {
            return this.strikeDetailsField;
        }
        set
        {
            this.strikeDetailsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentPaymentStrikeDefinitionsStrikeDefinitionStrikeDetail
{

    private uint underlyingKeyField;

    private decimal strikeLevelField;

    private string strikeCurrencyCodeField;

    private object strikeFixingDateTypeField;

    private System.DateTime strikeFixingDateField;

    private object strikeFixingDayPriceTypeField;

    private object strikeFixingTimeField;

    private object strikeFixingFunctionTypeField;

    private object strikeFixingEndDateField;

    private object strikeFixingPeriodicTypeField;

    private object strikeFixingIntervalField;

    private object strikeFixingIntervalTypeField;

    /// <remarks/>
    public uint UnderlyingKey
    {
        get
        {
            return this.underlyingKeyField;
        }
        set
        {
            this.underlyingKeyField = value;
        }
    }

    /// <remarks/>
    public decimal StrikeLevel
    {
        get
        {
            return this.strikeLevelField;
        }
        set
        {
            this.strikeLevelField = value;
        }
    }

    /// <remarks/>
    public string StrikeCurrencyCode
    {
        get
        {
            return this.strikeCurrencyCodeField;
        }
        set
        {
            this.strikeCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public object StrikeFixingDateType
    {
        get
        {
            return this.strikeFixingDateTypeField;
        }
        set
        {
            this.strikeFixingDateTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime StrikeFixingDate
    {
        get
        {
            return this.strikeFixingDateField;
        }
        set
        {
            this.strikeFixingDateField = value;
        }
    }

    /// <remarks/>
    public object StrikeFixingDayPriceType
    {
        get
        {
            return this.strikeFixingDayPriceTypeField;
        }
        set
        {
            this.strikeFixingDayPriceTypeField = value;
        }
    }

    /// <remarks/>
    public object StrikeFixingTime
    {
        get
        {
            return this.strikeFixingTimeField;
        }
        set
        {
            this.strikeFixingTimeField = value;
        }
    }

    /// <remarks/>
    public object StrikeFixingFunctionType
    {
        get
        {
            return this.strikeFixingFunctionTypeField;
        }
        set
        {
            this.strikeFixingFunctionTypeField = value;
        }
    }

    /// <remarks/>
    public object StrikeFixingEndDate
    {
        get
        {
            return this.strikeFixingEndDateField;
        }
        set
        {
            this.strikeFixingEndDateField = value;
        }
    }

    /// <remarks/>
    public object StrikeFixingPeriodicType
    {
        get
        {
            return this.strikeFixingPeriodicTypeField;
        }
        set
        {
            this.strikeFixingPeriodicTypeField = value;
        }
    }

    /// <remarks/>
    public object StrikeFixingInterval
    {
        get
        {
            return this.strikeFixingIntervalField;
        }
        set
        {
            this.strikeFixingIntervalField = value;
        }
    }

    /// <remarks/>
    public object StrikeFixingIntervalType
    {
        get
        {
            return this.strikeFixingIntervalTypeField;
        }
        set
        {
            this.strikeFixingIntervalTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.vontobel.com/dataservice/v1.0", IncludeInSchema = false)]
public enum ItemsChoiceType1
{

    /// <remarks/>
    BarrierDefinitions,

    /// <remarks/>
    CashDefinition,

    /// <remarks/>
    CurrencyPairFixingDate,

    /// <remarks/>
    CurrencyPairFixingTime,

    /// <remarks/>
    CurrentDenomination,

    /// <remarks/>
    DependUnderlyingRoleType,

    /// <remarks/>
    DetachmentType,

    /// <remarks/>
    EarningBeginDate,

    /// <remarks/>
    EarningEndDate,

    /// <remarks/>
    EarningNumberOfDays,

    /// <remarks/>
    EarningSpecificationType,

    /// <remarks/>
    FractionMgmtTyp,

    /// <remarks/>
    FractionMgmtType,

    /// <remarks/>
    IncomeType,

    /// <remarks/>
    PaymentCapLevel,

    /// <remarks/>
    PaymentCapRate,

    /// <remarks/>
    PaymentCutoff,

    /// <remarks/>
    PaymentDescription,

    /// <remarks/>
    PaymentEligibilityDate,

    /// <remarks/>
    PaymentExDate,

    /// <remarks/>
    PaymentFixingDate,

    /// <remarks/>
    PaymentFixingDateType,

    /// <remarks/>
    PaymentFixingDayPriceType,

    /// <remarks/>
    PaymentFixingEndDate,

    /// <remarks/>
    PaymentFixingFunctionType,

    /// <remarks/>
    PaymentFixingInterval,

    /// <remarks/>
    PaymentFixingIntervalType,

    /// <remarks/>
    PaymentFixingPeriodicType,

    /// <remarks/>
    PaymentFixingTime,

    /// <remarks/>
    PaymentFloorLevel,

    /// <remarks/>
    PaymentFloorRate,

    /// <remarks/>
    PaymentTriggerFlag,

    /// <remarks/>
    PaymentType,

    /// <remarks/>
    PaymentValueDate,

    /// <remarks/>
    PaymentValueDays,

    /// <remarks/>
    PaymentValueDaysType,

    /// <remarks/>
    SettlementType,

    /// <remarks/>
    StrikeDefinitions,
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentTradingVenues
{

    private IBTTermSheetInstrumentTradingVenuesTradingVenue tradingVenueField;

    /// <remarks/>
    public IBTTermSheetInstrumentTradingVenuesTradingVenue TradingVenue
    {
        get
        {
            return this.tradingVenueField;
        }
        set
        {
            this.tradingVenueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentTradingVenuesTradingVenue
{

    private object tradingExchangeCodeField;

    private string tradingCurrencyCodeField;

    private string contributorPriceSourcePageField;

    private System.DateTime firstTradingDateField;

    private System.DateTime lastTradingDateField;

    private System.DateTime lastTradingTimeField;

    private object tradingSymbolField;

    private decimal smallestTradeableUnitField;

    private string dirtyFlagField;

    /// <remarks/>
    public object TradingExchangeCode
    {
        get
        {
            return this.tradingExchangeCodeField;
        }
        set
        {
            this.tradingExchangeCodeField = value;
        }
    }

    /// <remarks/>
    public string TradingCurrencyCode
    {
        get
        {
            return this.tradingCurrencyCodeField;
        }
        set
        {
            this.tradingCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public string ContributorPriceSourcePage
    {
        get
        {
            return this.contributorPriceSourcePageField;
        }
        set
        {
            this.contributorPriceSourcePageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime FirstTradingDate
    {
        get
        {
            return this.firstTradingDateField;
        }
        set
        {
            this.firstTradingDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime LastTradingDate
    {
        get
        {
            return this.lastTradingDateField;
        }
        set
        {
            this.lastTradingDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
    public System.DateTime LastTradingTime
    {
        get
        {
            return this.lastTradingTimeField;
        }
        set
        {
            this.lastTradingTimeField = value;
        }
    }

    /// <remarks/>
    public object TradingSymbol
    {
        get
        {
            return this.tradingSymbolField;
        }
        set
        {
            this.tradingSymbolField = value;
        }
    }

    /// <remarks/>
    public decimal SmallestTradeableUnit
    {
        get
        {
            return this.smallestTradeableUnitField;
        }
        set
        {
            this.smallestTradeableUnitField = value;
        }
    }

    /// <remarks/>
    public string DirtyFlag
    {
        get
        {
            return this.dirtyFlagField;
        }
        set
        {
            this.dirtyFlagField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentParty
{

    private byte partyTypeField;

    private uint tKPartyKeyField;

    private string sISPartyBPIdField;

    private string bBCompanyIdField;

    private string wMPartyIdField;

    private string xetraPartyIdField;

    private string lEIField;

    private object kVPartyIdField;

    private object oeKBIdField;

    private string bICField;

    private string partyNameField;

    private string partyAreaCodeField;

    private string partyLocationField;

    private string custodyTypeField;

    private string certificationTypeField;

    private string guaranteeTypeField;

    private string ratingField;

    private IBTTermSheetInstrumentPartyRatings ratingsField;

    /// <remarks/>
    public byte PartyType
    {
        get
        {
            return this.partyTypeField;
        }
        set
        {
            this.partyTypeField = value;
        }
    }

    /// <remarks/>
    public uint TKPartyKey
    {
        get
        {
            return this.tKPartyKeyField;
        }
        set
        {
            this.tKPartyKeyField = value;
        }
    }

    /// <remarks/>
    public string SISPartyBPId
    {
        get
        {
            return this.sISPartyBPIdField;
        }
        set
        {
            this.sISPartyBPIdField = value;
        }
    }

    /// <remarks/>
    public string BBCompanyId
    {
        get
        {
            return this.bBCompanyIdField;
        }
        set
        {
            this.bBCompanyIdField = value;
        }
    }

    /// <remarks/>
    public string WMPartyId
    {
        get
        {
            return this.wMPartyIdField;
        }
        set
        {
            this.wMPartyIdField = value;
        }
    }

    /// <remarks/>
    public string XetraPartyId
    {
        get
        {
            return this.xetraPartyIdField;
        }
        set
        {
            this.xetraPartyIdField = value;
        }
    }

    /// <remarks/>
    public string LEI
    {
        get
        {
            return this.lEIField;
        }
        set
        {
            this.lEIField = value;
        }
    }

    /// <remarks/>
    public object KVPartyId
    {
        get
        {
            return this.kVPartyIdField;
        }
        set
        {
            this.kVPartyIdField = value;
        }
    }

    /// <remarks/>
    public object OeKBId
    {
        get
        {
            return this.oeKBIdField;
        }
        set
        {
            this.oeKBIdField = value;
        }
    }

    /// <remarks/>
    public string BIC
    {
        get
        {
            return this.bICField;
        }
        set
        {
            this.bICField = value;
        }
    }

    /// <remarks/>
    public string PartyName
    {
        get
        {
            return this.partyNameField;
        }
        set
        {
            this.partyNameField = value;
        }
    }

    /// <remarks/>
    public string PartyAreaCode
    {
        get
        {
            return this.partyAreaCodeField;
        }
        set
        {
            this.partyAreaCodeField = value;
        }
    }

    /// <remarks/>
    public string PartyLocation
    {
        get
        {
            return this.partyLocationField;
        }
        set
        {
            this.partyLocationField = value;
        }
    }

    /// <remarks/>
    public string CustodyType
    {
        get
        {
            return this.custodyTypeField;
        }
        set
        {
            this.custodyTypeField = value;
        }
    }

    /// <remarks/>
    public string CertificationType
    {
        get
        {
            return this.certificationTypeField;
        }
        set
        {
            this.certificationTypeField = value;
        }
    }

    /// <remarks/>
    public string GuaranteeType
    {
        get
        {
            return this.guaranteeTypeField;
        }
        set
        {
            this.guaranteeTypeField = value;
        }
    }

    /// <remarks/>
    public string Rating
    {
        get
        {
            return this.ratingField;
        }
        set
        {
            this.ratingField = value;
        }
    }

    /// <remarks/>
    public IBTTermSheetInstrumentPartyRatings Ratings
    {
        get
        {
            return this.ratingsField;
        }
        set
        {
            this.ratingsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentPartyRatings
{

    private string moodysField;

    private string standardAndPoorsField;

    private object fitchField;

    /// <remarks/>
    public string Moodys
    {
        get
        {
            return this.moodysField;
        }
        set
        {
            this.moodysField = value;
        }
    }

    /// <remarks/>
    public string StandardAndPoors
    {
        get
        {
            return this.standardAndPoorsField;
        }
        set
        {
            this.standardAndPoorsField = value;
        }
    }

    /// <remarks/>
    public object Fitch
    {
        get
        {
            return this.fitchField;
        }
        set
        {
            this.fitchField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentDistributionRestriction
{

    private string distributionAreaCodeField;

    private byte distributionAudienceTypeField;

    private System.DateTime publicOfferingStartDateField;

    private System.DateTime publicOfferingEndDateField;

    private string derinetDisplayLevelField;

    /// <remarks/>
    public string DistributionAreaCode
    {
        get
        {
            return this.distributionAreaCodeField;
        }
        set
        {
            this.distributionAreaCodeField = value;
        }
    }

    /// <remarks/>
    public byte DistributionAudienceType
    {
        get
        {
            return this.distributionAudienceTypeField;
        }
        set
        {
            this.distributionAudienceTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime PublicOfferingStartDate
    {
        get
        {
            return this.publicOfferingStartDateField;
        }
        set
        {
            this.publicOfferingStartDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime PublicOfferingEndDate
    {
        get
        {
            return this.publicOfferingEndDateField;
        }
        set
        {
            this.publicOfferingEndDateField = value;
        }
    }

    /// <remarks/>
    public string DerinetDisplayLevel
    {
        get
        {
            return this.derinetDisplayLevelField;
        }
        set
        {
            this.derinetDisplayLevelField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.vontobel.com/dataservice/v1.0")]
public partial class IBTTermSheetInstrumentTransactionRestriction
{

    private byte transactionTypeField;

    private object transactionAreaCodeField;

    private string restrictionAreaCodeField;

    private object excludedRestrictionAreaCodeField;

    private byte restrictionSubjectTypeField;

    private object restrictionDaysField;

    private string restrictionBeginDateField;

    private string restrictionEndDateField;

    private object restrictionMaxAmountField;

    private object restrictionMinAmountField;

    private object restrictionCurrencyCodeField;

    private object restrictionDescriptionField;

    /// <remarks/>
    public byte TransactionType
    {
        get
        {
            return this.transactionTypeField;
        }
        set
        {
            this.transactionTypeField = value;
        }
    }

    /// <remarks/>
    public object TransactionAreaCode
    {
        get
        {
            return this.transactionAreaCodeField;
        }
        set
        {
            this.transactionAreaCodeField = value;
        }
    }

    /// <remarks/>
    public string RestrictionAreaCode
    {
        get
        {
            return this.restrictionAreaCodeField;
        }
        set
        {
            this.restrictionAreaCodeField = value;
        }
    }

    /// <remarks/>
    public object ExcludedRestrictionAreaCode
    {
        get
        {
            return this.excludedRestrictionAreaCodeField;
        }
        set
        {
            this.excludedRestrictionAreaCodeField = value;
        }
    }

    /// <remarks/>
    public byte RestrictionSubjectType
    {
        get
        {
            return this.restrictionSubjectTypeField;
        }
        set
        {
            this.restrictionSubjectTypeField = value;
        }
    }

    /// <remarks/>
    public object RestrictionDays
    {
        get
        {
            return this.restrictionDaysField;
        }
        set
        {
            this.restrictionDaysField = value;
        }
    }

    /// <remarks/>
    public string RestrictionBeginDate
    {
        get
        {
            return this.restrictionBeginDateField;
        }
        set
        {
            this.restrictionBeginDateField = value;
        }
    }

    /// <remarks/>
    public string RestrictionEndDate
    {
        get
        {
            return this.restrictionEndDateField;
        }
        set
        {
            this.restrictionEndDateField = value;
        }
    }

    /// <remarks/>
    public object RestrictionMaxAmount
    {
        get
        {
            return this.restrictionMaxAmountField;
        }
        set
        {
            this.restrictionMaxAmountField = value;
        }
    }

    /// <remarks/>
    public object RestrictionMinAmount
    {
        get
        {
            return this.restrictionMinAmountField;
        }
        set
        {
            this.restrictionMinAmountField = value;
        }
    }

    /// <remarks/>
    public object RestrictionCurrencyCode
    {
        get
        {
            return this.restrictionCurrencyCodeField;
        }
        set
        {
            this.restrictionCurrencyCodeField = value;
        }
    }

    /// <remarks/>
    public object RestrictionDescription
    {
        get
        {
            return this.restrictionDescriptionField;
        }
        set
        {
            this.restrictionDescriptionField = value;
        }
    }
}

