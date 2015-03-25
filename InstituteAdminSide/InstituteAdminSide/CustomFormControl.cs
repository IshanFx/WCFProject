using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    class CustomFormControl
    {


        public void FormLoad(Form newForm,Form currentForm)
        {
            newForm.Show();
            currentForm.Hide();
        }
    }
}
