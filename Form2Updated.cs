// File: HellowWorld/Form2.cs

public Form2()
{
    InitializeComponent();

    Label helloLabel = new Label();
    helloLabel.AutoSize = true;
    helloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
    helloLabel.Location = new Point(30, 30);
    helloLabel.Name = "helloLabel";
    helloLabel.TabIndex = 0;
    helloLabel.Text = "Hello Ascendion";   // updated per KAN-4
    Controls.Add(helloLabel);
}
