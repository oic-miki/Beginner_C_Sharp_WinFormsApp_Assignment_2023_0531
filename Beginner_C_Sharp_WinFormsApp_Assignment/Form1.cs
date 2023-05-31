namespace Beginner_C_Sharp_WinFormsApp_Assignment
{

    /// <summary>
    /// ������^����
    /// </summary>
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            displayForm2();

            displayForm3();

        }

        /*
         * �y�f�o�b�O�����Ă݂悤�z
         * 
         * ���̂���\�[�X�R�[�h��z�z���܂��̂ŁA������������Ă��������B
         * ���ꌩ���Ȃ������ȃR�[�h������܂�
         * 
         * �܂��A�������������Ăق������e���L�q����Ă��܂��̂ŁA��������������Ă��������B
         */

        /// <summary>
        /// �u7 + 3 = 10�v�ƕ\�����������B
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = 7;
            int num2 = 3;
            int result = num1 + num2;

            label1.Text = num1 + " + " + num2 + " = " + result;

        }

        /// <summary>
        /// num1 �� num2 �̌��ʂ�\�����������B
        /// �G���[�Ŏ~�܂��Ăق����Ȃ��B
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int result = 0;

                result = num1 / num2;

                label2.Text = result.ToString();

            }
            catch (FormatException formatException)
            {

                label2.Text = formatException.Message;

            }
            catch (OverflowException overflowException)
            {

                label2.Text = overflowException.Message;

            }
            catch (DivideByZeroException divideByZeroException)
            {

                label2.Text = divideByZeroException.Message;

            }

        }

        /*
         * �������6�擾���A5W1H�̕��͂��쐬����v���O�����R�[�h�������Ă��������B
         * ��5W1H���܂܂�镶�̗͂�F�u��T�A���͊w�Z����ۑ��^����ꂽ���߁A�����PC���g���Ă��̉ۑ�������������B�v
         * 
         * e.g.)
         * �@���́FWhen�i���j�AWhere�i�ǂ��Łj�AWho�i�N���j�AWhat�i�����j�AWhy�i�Ȃ��j�AHow�i�ǂ̂悤�Ɂj
         * �@�o�́F�u����A�A�蓹�ŁA�����A�l�R���A��������ƁA�����ƕ��łĂ����B�v
         * �@
         * �@1. ����"5W1H"�̌����ߌ`���ɕϊ�����
         * �@   ���u [When] �A [Where] �A [Who] �A [What] �A [Why] �A [How] �B�v
         * �@2. ���̓G���A�����
         * �@3. �{�^�������
         * �@4. ���͂̕\���G���A�����
         * �@5. �{�^���������ꂽ�� 1 �ō�����󗓂ɓ��͂��ꂽ�������Z�b�g����
         * �@6. 5 �ō�������͂�\������
         */
        public void displayForm2()
        {

            new Form2().Show();

        }

        /*
         * 1�`100�̃����_���Ȑ�����2�g���A�l�����Z�̌��ʂ�\������v���O�����R�[�h�������Ă��������B
         * 
         * �����_���Ȑ����̔������@�F
         *    Random random = new Random(); �������_���I�u�W�F�N�g�𐶐�
         *    int number = random.Next(0, 10); ��0�`9�̐������Ă΂�邽�тɔ���
         * 
         * e.g.)
         * �@�o�͌��ʁF�u32 �{ 78 �� 110�v�u85 �| 24 �� 61�v�u5 �~ 61 �� 305�v�u40 �� 2 �� 20�v
         * 
         * cf.)
         * �wC#��Random�̎g�����bRandom�N���X�̋@�\�Ɨ����z��̐����x
         * https://www.fenet.jp/dotnet/column/language/8212/
         * 
         * �@1. �����\���p�̃��x���A����щ��Z���\���p�̃��x�������
         * �@2. �l�ύX�p�̃{�^�������
         * �@3. �����_���̃I�u�W�F�N�g�𐶐�����
         * �@4. ���ӂ̐��l�𐶐����A���ӂ̃��x���ɐݒ肷��
         * �@5. �E�ӂ̐��l�𐶐����A�E�ӂ̃��x���ɐݒ肷��
         * �@6. �l�����Z���ꂼ��̌��ʂ��񓚃��x���ɐݒ肷��
         */
        public void displayForm3()
        {

            new Form3().Show();

        }

    }

}