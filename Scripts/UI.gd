extends Control
func _ready() -> void:
	connect($VBoxContainer/LicensesButton.pressed, licensesPressed)

func licensesPressed() -> void:
	$Licenses/AnimationPlayer.play("Open")
