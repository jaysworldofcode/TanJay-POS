using TanjayPOS.DB;
using TanjayPOS.Model;

namespace TanjayPOS.Reusable_Code
{
    public class Update_UnitLeft
    {
        POS_Items_Model ItemsModel;
        Stock_Data_Model StockModel;
        public Update_UnitLeft(
            POS_Items_Model ItemsModel,
            Stock_Data_Model StockModel)
        {
            this.ItemsModel = ItemsModel;
            this.StockModel = StockModel;
        }
        public void UpdateChecker()
        {
            /*
             * --Update unit left in DB--
             * Reusable updating unit left
             * in DB from 2 models (POS and Stock)
             */
            POS_DB pos_db = new POS_DB();
            for (int count = 0; count < ItemsModel.getItemName().Count; count++)
            {
                pos_db.UpdateDataUnitLeft(
                    ItemsModel.getCode()[count].ToString(),
                    StockModel.getUnitLeft()[
                        StockModel.getCode().IndexOf(
                            ItemsModel.getCode()[count].ToString()
                        )
                    ].ToString()
                );
            }
        }
    }
}